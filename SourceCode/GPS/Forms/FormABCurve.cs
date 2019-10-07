﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace AgOpenGPS
{
    public partial class FormABCurve : Form
    {
        public List<CurveLines> curveArrs = new List<CurveLines>();

        //access to the main GPS form and all its variables
        private readonly FormGPS mf;

        private string filename = "";

        public FormABCurve(Form _mf)
        {
            mf = _mf as FormGPS;
            InitializeComponent();

            lblEnterCurveName.Text = gStr.gsEnterCurveName;
            btnMulti.Text = gStr.gsShow;
            btnPausePlay.Text = gStr.gsPause;
        }

        private void FormABCurve_Load(object sender, EventArgs e)
        {
            btnPausePlay.Enabled = false;
            btnAPoint.Enabled = true;
            btnBPoint.Enabled = false;
            mf.curve.isOkToAddPoints = false;

            if (mf.curve.refList.Count > 3)
            {
                lblCurveExists.Text = "Curve Set";
                btnABLineOk.Enabled = true;
            }
            else
            {
                mf.curve.ResetCurveLine();
                lblCurveExists.Text = " > Off <";
                btnABLineOk.Enabled = false;
            }
            lvLines.Clear();
            curveArrs.Clear();
            FormABCurve_LoadCurves();

            this.Size = new System.Drawing.Size(280, 440);
            btnMulti.Image = Properties.Resources.ArrowLeft;
        }

        //for calculating for display the averaged new line
        public void SmoothAB(int smPts)
        {
            //count the reference list of original curve
            int cnt = mf.curve.refList.Count;

            //the temp array
            vec3[] arr = new vec3[cnt];

            //read the points before and after the setpoint
            for (int s = 0; s < smPts / 2; s++)
            {
                arr[s].easting = mf.curve.refList[s].easting;
                arr[s].northing = mf.curve.refList[s].northing;
                arr[s].heading = mf.curve.refList[s].heading;
            }

            for (int s = cnt - (smPts / 2); s < cnt; s++)
            {
                arr[s].easting = mf.curve.refList[s].easting;
                arr[s].northing = mf.curve.refList[s].northing;
                arr[s].heading = mf.curve.refList[s].heading;
            }

            //average them - center weighted average
            for (int i = smPts / 2; i < cnt - (smPts / 2); i++)
            {
                for (int j = -smPts / 2; j < smPts / 2; j++)
                {
                    arr[i].easting += mf.curve.refList[j + i].easting;
                    arr[i].northing += mf.curve.refList[j + i].northing;
                }
                arr[i].easting /= smPts;
                arr[i].northing /= smPts;
                arr[i].heading = mf.curve.refList[i].heading;
            }

            //make a list to draw
            mf.curve.refList?.Clear();
            for (int i = 0; i < cnt; i++)
            {
                mf.curve.refList.Add(arr[i]);
            }
        }

        private void btnABLineOk_Click(object sender, System.EventArgs e)
        {
            if (mf.curve.refList.Count < 3)
            {
                mf.curve.isCurveBtnOn = false;
                mf.btnCurve.Image = Properties.Resources.CurveOff;

                mf.curve.ResetCurveLine();
                mf.DisableYouTurnButtons();
                mf.FileSaveCurveLine();
                Close();
            }
            else
            {
                mf.curve.isCurveSet = true;
                mf.EnableYouTurnButtons();
                mf.FileSaveCurveLine();
                Close();
            }
        }

        private void btnAddToFile_Click(object sender, EventArgs e)
        {
            //get the directory and make sure it exists, create if not
            string dirField = mf.fieldsDirectory + mf.currentFieldDirectory + "\\";
            string directoryName = Path.GetDirectoryName(dirField);

            if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
            { Directory.CreateDirectory(directoryName); }

            filename = directoryName + "\\CurveLines.txt";

            //use Streamwriter to create and overwrite existing curveLines file
            using (StreamWriter writer = new StreamWriter(filename, true))
            {
                try
                {
                    if (mf.curve.refList.Count > 0)
                    {
                        if (textBox1.Text.Length > 0)
                        {
                            curveArrs.Add(new CurveLines());
                            curveArrs[curveArrs.Count - 1].Name = textBox1.Text;
                            curveArrs[curveArrs.Count - 1].Heading = mf.curve.aveLineHeading;

                            ListViewItem itm = new ListViewItem(curveArrs[curveArrs.Count - 1].Name);
                            lvLines.Items.Add(itm);

                            //write out the ABLine
                            writer.WriteLine(textBox1.Text);

                            //write out the aveheading
                            writer.WriteLine(mf.curve.aveLineHeading.ToString(CultureInfo.InvariantCulture));

                            //write out the points of ref line
                            writer.WriteLine(mf.curve.refList.Count.ToString(CultureInfo.InvariantCulture));

                            for (int j = 0; j < mf.curve.refList.Count; j++)
                            {
                                curveArrs[curveArrs.Count - 1].curveArr.Add(mf.curve.refList[j]);
                                writer.WriteLine(Math.Round(mf.curve.refList[j].easting, 3).ToString(CultureInfo.InvariantCulture) + "," +
                                                        Math.Round(mf.curve.refList[j].northing, 3).ToString(CultureInfo.InvariantCulture) + "," +
                                                            Math.Round(mf.curve.refList[j].heading, 5).ToString(CultureInfo.InvariantCulture));
                            }
                        }
                        else
                        {
                            //MessageBox.Show("Currently no ABCurve name\n      create ABCurve name");
                            var form2 = new FormTimedMessage(2000, gStr.gsNoNameEntered, gStr.gsEnterUniqueABCurveName);
                            form2.Show();
                        }
                        textBox1.Clear();
                    }
                    else
                    {
                        var form2 = new FormTimedMessage(2000, gStr.gsNoABCurveCreated, gStr.gsCompleteAnABCurveLineFirst);
                        form2.Show();
                    }
                }
                catch (Exception er)
                {
                    mf.WriteErrorLog("Saving Curve Line" + er.ToString());

                    return;
                }
            }
        }

        private void btnAPoint_Click(object sender, System.EventArgs e)
        {
            //clear out the reference list
            lblCurveExists.Text = "Driving";
            mf.curve.ResetCurveLine();

            mf.curve.isOkToAddPoints = true;
            btnBPoint.Enabled = true;
            btnAPoint.Enabled = false;
            btnMulti.Enabled = false;
            btnABLineOk.Enabled = false;
            btnCancel.Enabled = false;
            btnPausePlay.Enabled = true;

            ShowSavedPanel(false);
        }

        private void btnBPoint_Click(object sender, System.EventArgs e)
        {
            mf.curve.aveLineHeading = 0;
            mf.curve.isOkToAddPoints = false;
            btnBPoint.Enabled = false;
            btnAPoint.Enabled = true;
            btnABLineOk.Enabled = true;
            btnPausePlay.Enabled = false;
            btnMulti.Enabled = true;
            btnABLineOk.Enabled = true;
            btnCancel.Enabled = true;

            int cnt = mf.curve.refList.Count;
            if (cnt > 3)
            {
                //make sure distance isn't too big between points on Turn
                for (int i = 0; i < cnt - 1; i++)
                {
                    int j = i + 1;
                    //if (j == cnt) j = 0;
                    double distance = glm.Distance(mf.curve.refList[i], mf.curve.refList[j]);
                    if (distance > 1.2)
                    {
                        vec3 pointB = new vec3((mf.curve.refList[i].easting + mf.curve.refList[j].easting) / 2.0,
                            (mf.curve.refList[i].northing + mf.curve.refList[j].northing) / 2.0,
                            mf.curve.refList[i].heading);

                        mf.curve.refList.Insert(j, pointB);
                        cnt = mf.curve.refList.Count;
                        i = -1;
                    }
                }

                //calculate average heading of line
                double x = 0, y = 0;
                mf.curve.isCurveSet = true;
                foreach (var pt in mf.curve.refList)
                {
                    x += Math.Cos(pt.heading);
                    y += Math.Sin(pt.heading);
                }
                x /= mf.curve.refList.Count;
                y /= mf.curve.refList.Count;
                mf.curve.aveLineHeading = Math.Atan2(y, x);

                //build the tail extensions
                mf.curve.AddFirstLastPoints();
                SmoothAB(4);
                mf.curve.CalculateTurnHeadings();

                mf.curve.isCurveSet = true;
                mf.EnableYouTurnButtons();
                mf.FileSaveCurveLine();
                lblCurveExists.Text = "Curve Set";
            }
            else
            {
                mf.curve.isCurveSet = false;
                mf.curve.refList?.Clear();
                lblCurveExists.Text = " > Off <";
            }
            //Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            mf.curve.isOkToAddPoints = false;
            mf.curve.isCurveSet = false;
            mf.DisableYouTurnButtons();
            mf.btnContourPriority.Enabled = false;
            //mf.curve.ResetCurveLine();
            mf.curve.isCurveBtnOn = false;
            mf.btnCurve.Image = Properties.Resources.CurveOff;
            Close();
        }

        private void btnListDelete_Click(object sender, EventArgs e)
        {
            //get the directory and make sure it exists, create if not
            string dirField = mf.fieldsDirectory + mf.currentFieldDirectory + "\\";
            string directoryName = Path.GetDirectoryName(dirField);

            if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
            { Directory.CreateDirectory(directoryName); }

            filename = directoryName + "\\CurveLines.txt";

            int count = lvLines.SelectedItems.Count;
            if (count > 0)
            {
                int num = lvLines.SelectedIndices[0];
                curveArrs.RemoveAt(num);
                lvLines.SelectedItems[0].Remove();
            }
            using (StreamWriter writer = new StreamWriter(filename, false))
            {
                try
                {
                    writer.WriteLine("$CurveLines");
                    for (int i = 0; i < curveArrs.Count; i++)
                    {
                        //curveArrs[i].curveArr

                        //write out the Name
                        writer.WriteLine(curveArrs[i].Name);

                        //write out the aveheading
                        writer.WriteLine(curveArrs[i].Heading.ToString(CultureInfo.InvariantCulture));

                        //write out the points of ref line
                        writer.WriteLine(curveArrs[i].curveArr.Count.ToString(CultureInfo.InvariantCulture));
                        if (curveArrs[i].curveArr.Count > 0)
                        {
                            for (int j = 0; j < curveArrs[i].curveArr.Count; j++)
                                writer.WriteLine(Math.Round(curveArrs[i].curveArr[j].easting, 3).ToString(CultureInfo.InvariantCulture) + "," +
                                                    Math.Round(curveArrs[i].curveArr[j].northing, 3).ToString(CultureInfo.InvariantCulture) + "," +
                                                        Math.Round(curveArrs[i].curveArr[j].heading, 5).ToString(CultureInfo.InvariantCulture));
                        }
                    }
                }
                catch (Exception er)
                {
                    mf.WriteErrorLog("Saving Curve Line" + er.ToString());

                    return;
                }
            }
        }

        private void btnListUse_Click(object sender, EventArgs e)
        {
            int count = lvLines.SelectedItems.Count;

            if (count > 0)
            {
                int aa = lvLines.SelectedIndices[0];

                mf.curve.aveLineHeading = curveArrs[aa].Heading;

                mf.curve.refList?.Clear();

                for (int i = 0; i < curveArrs[aa].curveArr.Count; i++)
                {
                    mf.curve.refList.Add(curveArrs[aa].curveArr[i]);
                }
                if (mf.curve.refList.Count < 3)
                {
                    mf.btnCurve.PerformClick();
                    mf.curve.ResetCurveLine();
                    mf.DisableYouTurnButtons();
                }
                else
                {
                    mf.curve.isCurveSet = true;
                    mf.EnableYouTurnButtons();
                    mf.FileSaveCurveLine();
                }
                //can go back to Mainform without seeing ABLine form.
                //DialogResult = DialogResult.Yes;
                Close();
            }

            //no item selected
            else
            {
                return;
            }
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            if (this.Size.Width < 640)
            {
                ShowSavedPanel(true);
            }
            else
            {
                ShowSavedPanel(false);
            }
        }

        private void btnPausePlay_Click(object sender, EventArgs e)
        {
            if (mf.curve.isOkToAddPoints)
            {
                mf.curve.isOkToAddPoints = false;
                btnPausePlay.Image = Properties.Resources.BoundaryRecord;
                btnPausePlay.Text = gStr.gsRecord;
                btnBPoint.Enabled = false;
            }
            else
            {
                mf.curve.isOkToAddPoints = true;
                btnPausePlay.Image = Properties.Resources.boundaryPause;
                btnPausePlay.Text = gStr.gsPause;
                btnBPoint.Enabled = true;
            }
        }


        private void FormABCurve_LoadCurves()
        {
            //get the directory and make sure it exists, create if not
            string dirField = mf.fieldsDirectory + mf.currentFieldDirectory + "\\";
            string directoryName = Path.GetDirectoryName(dirField);

            if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
            { Directory.CreateDirectory(directoryName); }

            filename = directoryName + "\\CurveLines.txt";

            if (!File.Exists(filename))
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine("$CurveLines");
                }
            }

            //get the file of previous AB Lines
            if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
            { Directory.CreateDirectory(directoryName); }
            if (!File.Exists(filename))
            {
                mf.TimedMessageBox(2000, gStr.gsFileError, gStr.gsMissingABCurveFile);
            }
            else
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    try
                    {
                        ListViewItem itm;
                        string line;
                        int num = 0;

                        //read header $CurveLine
                        line = reader.ReadLine();

                        while (!reader.EndOfStream)
                        {
                            curveArrs.Add(new CurveLines());

                            //read header $CurveLine
                            curveArrs[num].Name = reader.ReadLine();
                            // get the average heading
                            line = reader.ReadLine();
                            curveArrs[num].Heading = double.Parse(line, CultureInfo.InvariantCulture);

                            line = reader.ReadLine();
                            int numPoints = int.Parse(line);

                            if (numPoints > 1)
                            {
                                itm = new ListViewItem(curveArrs[num].Name);
                                lvLines.Items.Add(itm);

                                curveArrs[num].curveArr?.Clear();

                                for (int i = 0; i < numPoints; i++)
                                {
                                    line = reader.ReadLine();
                                    string[] words = line.Split(',');
                                    vec3 vecPt = new vec3(double.Parse(words[0], CultureInfo.InvariantCulture),
                                        double.Parse(words[1], CultureInfo.InvariantCulture),
                                        double.Parse(words[2], CultureInfo.InvariantCulture));
                                    curveArrs[num].curveArr.Add(vecPt);
                                }
                                num++;
                            }
                            else
                            {
                                if (curveArrs.Count > 0)
                                {
                                    curveArrs.RemoveAt(num);
                                }
                            }
                        }
                    }
                    catch (Exception er)
                    {
                        var form = new FormTimedMessage(2000, gStr.gsCurveLineFileIsCorrupt, gStr.gsButFieldIsLoaded);
                        form.Show();
                        mf.WriteErrorLog("Load Curve Line" + er.ToString());
                    }
                }

                // go to bottom of list - if there is a bottom
                if (lvLines.Items.Count > 0) lvLines.Items[lvLines.Items.Count - 1].EnsureVisible();
            }
        }

        private void ShowSavedPanel(bool showPanel)
        {
            if (showPanel)
            {
                this.Size = new System.Drawing.Size(650, 440);
                btnAddToFile.Visible = true;
                btnListDelete.Visible = true;
                btnListUse.Visible = true;
                lblEnterCurveName.Visible = true;
                textBox1.Visible = true;
                lvLines.Visible = true;
                btnMulti.Text = gStr.gsHide;
                btnMulti.Image = Properties.Resources.ArrowRight;
            }
            else
            {
                this.Size = new System.Drawing.Size(280, 440);
                btnAddToFile.Visible = false;
                btnListDelete.Visible = false;
                btnListUse.Visible = false;
                lblEnterCurveName.Visible = false;
                textBox1.Visible = false;
                lvLines.Visible = false;
                btnMulti.Text = gStr.gsShow;
                btnMulti.Image = Properties.Resources.ArrowLeft;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int count = lvLines.SelectedItems.Count;
            if (count > 0)
            {
                btnListDelete.Enabled = true;
                btnListUse.Enabled = true;
            }
            else
            {
                btnListDelete.Enabled = false;
                btnListUse.Enabled = false;
            }
        }
    }

    public class CurveLines
    {
        public List<vec3> curveArr = new List<vec3>();
        public double Heading = 3;
        public string Name = "aa";
    }
}