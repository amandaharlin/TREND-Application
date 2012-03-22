using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;
using NHibernate;
using NHibernate.Linq;
using TrendWinForm.MyUtilities;

using TrendWinForm;

namespace TrendWinForm.MyUtilities
{
    class ListViewToDetailsFields
    {
        public static void ComputerlistViewToDetailFields(Computer thisComputer, Create_Case createCaseFormInstance)
        {
            //general information
            createCaseFormInstance.txtMakeOutput.Text = thisComputer.Make;
            createCaseFormInstance.txtModelOutput.Text = thisComputer.Model;
            createCaseFormInstance.txtTypeOutput.Text = thisComputer.Type;
            createCaseFormInstance.txtSerialNum.Text = thisComputer.SerialNumber;
            createCaseFormInstance.txtSvcTag.Text = thisComputer.SvcTag;

            //cmos settings
            createCaseFormInstance.txtCMOSDate.Text = thisComputer.CmosDate.Date.ToString();
            createCaseFormInstance.txtCMOSTime.Text = thisComputer.CmosDate.TimeOfDay.ToString();
            createCaseFormInstance.txtActualDate.Text = thisComputer.CmosDate.Date.ToString();
            createCaseFormInstance.txtActualTime.Text = thisComputer.CmosDate.TimeOfDay.ToString();
            createCaseFormInstance.txtTimeProvidedBy.Text = thisComputer.ActualTimeProvidedBy;
            createCaseFormInstance.txtSetupKeystroke.Text = thisComputer.KeystrokeForCmosSetup;
            createCaseFormInstance.txtWasCMOSChanged.Text = thisComputer.CmosWasChanged.ToString();
            createCaseFormInstance.txtCMOSChangesMade.Text = thisComputer.DescriptionOfCmosChanges;

            //sys info
            createCaseFormInstance.txtSystemRunning.Text = thisComputer.SystemWasRunning.ToString(); //bool
            createCaseFormInstance.txtPulledPlug.Text = thisComputer.PlugWasPulled.ToString(); //bool
            createCaseFormInstance.txtAppsRunning.Text = thisComputer.AppsWereRunning.ToString();
            createCaseFormInstance.txtShutDownBy.Text = thisComputer.WhoShutDown.ToString();
            createCaseFormInstance.txtWasItPoweredOn.Text = thisComputer.WasPoweredOn.ToString();
            createCaseFormInstance.txtWasItAServer.Text = thisComputer.WasServer.ToString();
            createCaseFormInstance.txtServerType.Text = thisComputer.ServerType;
            createCaseFormInstance.txtVirtualMachine.Text = thisComputer.WasVirtualMachine.ToString();
            createCaseFormInstance.txtHostedSystem.Text = thisComputer.WasHostedSystem.ToString();
            createCaseFormInstance.txtHostname.Text = thisComputer.Hostname;
            //HD information

            //cdfi info
            createCaseFormInstance.txtTechExaminer.Text = thisComputer.CdfInfo.TechExaminer.EmployeeName.FirstName.ToString() + " " + thisComputer.CdfInfo.TechExaminer.EmployeeName.LastName.ToString();
            createCaseFormInstance.txtFinishDateTime.Text = thisComputer.CdfInfo.Cdfdate.ToString();
        }

        private static Color setJumperBackgroundColor(int val)
        {
            switch (val)
            {

                case 1:
                    return Color.Lime;

                case 2:
                    return Color.Red;

                case 3:
                    return Color.Aqua;

                case 4:
                    return Color.Yellow;

                case 5:
                    return Color.FromArgb(64, 64, 64);

                default:
                    return Color.White;

            }

        }

        private static void resetjumpeerBackgroundColors(Create_Case c)
        {

            c.jumperPosition0.BackColor = Color.White;
            c.jumperPosition1.BackColor = Color.White;
            c.jumperPosition2.BackColor = Color.White;
            c.jumperPosition3.BackColor = Color.White;
            c.jumperPosition4.BackColor = Color.White;
            c.jumperPosition5.BackColor = Color.White;
            c.jumperPosition6.BackColor = Color.White;
            c.jumperPosition7.BackColor = Color.White;
            c.jumperPosition8.BackColor = Color.White;
            c.jumperPosition9.BackColor = Color.White;
        }

        //TODO FINISH MAPPING THIS!!!!!!!!
        public static void HardDrivelistViewToDetailFields(HardDrive thisCaseHardDrive, Create_Case createCaseFormInstance)
        {
            //hard drive details
            createCaseFormInstance.textBoxHDMakeOutput.Text = thisCaseHardDrive.Make;
            createCaseFormInstance.textBoxHDModelOutput.Text = thisCaseHardDrive.Model;
            createCaseFormInstance.textBoxHDTypeOutput.Text = thisCaseHardDrive.Type;
            createCaseFormInstance.textBoxHDSerialNumOutput.Text = thisCaseHardDrive.Serial;
            createCaseFormInstance.textBoxHDSizeOutput.Text = thisCaseHardDrive.SizeInGB.ToString();
            createCaseFormInstance.textBoxHDDriveInterfaceOutput.Text = thisCaseHardDrive.DriveInterface;
            createCaseFormInstance.textBoxHDDrivePositionOutput.Text = thisCaseHardDrive.DrivePosition;
            createCaseFormInstance.textBoxHDJumperSettingsOutput.Text = thisCaseHardDrive.JumperSetting;

            //jumper details
            resetjumpeerBackgroundColors(createCaseFormInstance);
            createCaseFormInstance.jumperPosition0.BackColor = setJumperBackgroundColor(thisCaseHardDrive.JumperDiagram.Jumper_0);
            createCaseFormInstance.jumperPosition1.BackColor = setJumperBackgroundColor(thisCaseHardDrive.JumperDiagram.Jumper_1);
            createCaseFormInstance.jumperPosition2.BackColor = setJumperBackgroundColor(thisCaseHardDrive.JumperDiagram.Jumper_2);
            createCaseFormInstance.jumperPosition3.BackColor = setJumperBackgroundColor(thisCaseHardDrive.JumperDiagram.Jumper_3);
            createCaseFormInstance.jumperPosition4.BackColor = setJumperBackgroundColor(thisCaseHardDrive.JumperDiagram.Jumper_4);
            createCaseFormInstance.jumperPosition5.BackColor = setJumperBackgroundColor(thisCaseHardDrive.JumperDiagram.Jumper_5);
            createCaseFormInstance.jumperPosition6.BackColor = setJumperBackgroundColor(thisCaseHardDrive.JumperDiagram.Jumper_6);
            createCaseFormInstance.jumperPosition7.BackColor = setJumperBackgroundColor(thisCaseHardDrive.JumperDiagram.Jumper_7);
            createCaseFormInstance.jumperPosition8.BackColor = setJumperBackgroundColor(thisCaseHardDrive.JumperDiagram.Jumper_8);
            createCaseFormInstance.jumperPosition9.BackColor = setJumperBackgroundColor(thisCaseHardDrive.JumperDiagram.Jumper_9);

            //cdf info
            createCaseFormInstance.textBoxHDTechExaminerOutput.Text = thisCaseHardDrive.CDFInfo.TechExaminer.EmployeeName.FirstName + " " + thisCaseHardDrive.CDFInfo.TechExaminer.EmployeeName.LastName.ToString();
            createCaseFormInstance.textBoxHDFinishDateTimeOutput.Text = thisCaseHardDrive.CDFInfo.Cdfdate.ToString();
            //related computer/reference computer
            if (thisCaseHardDrive.ReferenceComputer != null)
            {
                createCaseFormInstance.textBoxHDRelatedComputerMake.Text = thisCaseHardDrive.ReferenceComputer.Make;
                createCaseFormInstance.textBoxHDRelatedComputerModel.Text = thisCaseHardDrive.ReferenceComputer.Model;
                createCaseFormInstance.textBoxHDRelatedComputerType.Text = thisCaseHardDrive.ReferenceComputer.Type;
                createCaseFormInstance.textBoxHDRelatedComputerSerialNum.Text = thisCaseHardDrive.ReferenceComputer.SerialNumber;
                createCaseFormInstance.textBoxHDRelatedComputerSvcTag.Text = thisCaseHardDrive.ReferenceComputer.SvcTag;
                createCaseFormInstance.textBoxHDRelatedCompSysInfoSystemRunning.Text = thisCaseHardDrive.ReferenceComputer.SystemWasRunning.ToString();
                createCaseFormInstance.textBoxHDRelatedCompSysInfoPulledPlug.Text = thisCaseHardDrive.ReferenceComputer.PlugWasPulled.ToString();
                createCaseFormInstance.textBoxHDRelatedCompSysInfoAppsRunning.Text = thisCaseHardDrive.ReferenceComputer.AppsWereRunning.ToString();
                createCaseFormInstance.textBoxHDRelatedCompSysInfoShutDownBy.Text = thisCaseHardDrive.ReferenceComputer.WhoShutDown.EmployeeName.FirstName.ToString() + " " + thisCaseHardDrive.ReferenceComputer.WhoShutDown.EmployeeName.LastName.ToString();
                createCaseFormInstance.textBoxHDRelatedCompSysInfoPoweredOn.Text = thisCaseHardDrive.ReferenceComputer.WasPoweredOn.ToString();
                createCaseFormInstance.textBoxHDRelatedCompSysInfoServer.Text = thisCaseHardDrive.ReferenceComputer.WasServer.ToString();
                createCaseFormInstance.textBoxHDRelatedCompSysInfoServerType.Text = thisCaseHardDrive.ReferenceComputer.ServerType;
                createCaseFormInstance.textBoxHDRelatedCompSysInfoVirtualMachine.Text = thisCaseHardDrive.ReferenceComputer.WasVirtualMachine.ToString();
                createCaseFormInstance.textBoxHDRelatedCompSysInfoHostedSystem.Text = thisCaseHardDrive.ReferenceComputer.WasHostedSystem.ToString();
                createCaseFormInstance.textBoxHDRelatedCompSysInfoHostname.Text = thisCaseHardDrive.ReferenceComputer.Hostname;
                //computer image list
                IList<String> images = new List<string>();
                images.Add("TrendWinForm.Images.Icons.desktop_computer_48.png");
                images.Add("TrendWinForm.Images.Icons.laptop_computer_48.png");
                images.Add("TrendWinForm.Images.Icons.server_computer_48.png");
                images.Add("TrendWinForm.Images.Icons.mobile_computer_48.png");
                images.Add("TrendWinForm.Images.Icons.mystery_computer_48.png");

                ImageList computerImageList = new ImageList();
                computerImageList.ImageSize = new System.Drawing.Size(48, 48);
                computerImageList.ColorDepth = ColorDepth.Depth32Bit;
                images.ForEach(image =>
                {
                    Assembly myAssembly = Assembly.GetExecutingAssembly();
                    Stream myStream = myAssembly.GetManifestResourceStream(image);
                    Bitmap img = new Bitmap(myStream);
                    computerImageList.Images.Add(img);
                });

                if (thisCaseHardDrive.ReferenceComputer.Type == "Desktop")
                {
                    createCaseFormInstance.pictureBoxRelatedComputer.Image = computerImageList.Images[0];
                }
                else if (thisCaseHardDrive.ReferenceComputer.Type == "Laptop")
                {
                    createCaseFormInstance.pictureBoxRelatedComputer.Image = computerImageList.Images[1];
                }
                else if (thisCaseHardDrive.ReferenceComputer.Type == "Server")
                {
                    createCaseFormInstance.pictureBoxRelatedComputer.Image = computerImageList.Images[2];
                }
                else if (thisCaseHardDrive.ReferenceComputer.Type == "Mobile")
                {
                    createCaseFormInstance.pictureBoxRelatedComputer.Image = computerImageList.Images[3];
                }
                else
                {
                    createCaseFormInstance.pictureBoxRelatedComputer.Image = computerImageList.Images[4];
                }
            }
            else
            {
                createCaseFormInstance.textBoxHDRelatedComputerMake.Text = "";
                createCaseFormInstance.textBoxHDRelatedComputerModel.Text = "";
                createCaseFormInstance.textBoxHDRelatedComputerType.Text = "";
                createCaseFormInstance.textBoxHDRelatedComputerSerialNum.Text = "";
                createCaseFormInstance.textBoxHDRelatedComputerSvcTag.Text = "";
                createCaseFormInstance.textBoxHDRelatedCompSysInfoSystemRunning.Text = "";
                createCaseFormInstance.textBoxHDRelatedCompSysInfoPulledPlug.Text = "";
                createCaseFormInstance.textBoxHDRelatedCompSysInfoAppsRunning.Text = "";
                createCaseFormInstance.textBoxHDRelatedCompSysInfoShutDownBy.Text = "";
                createCaseFormInstance.textBoxHDRelatedCompSysInfoPoweredOn.Text = "";
                createCaseFormInstance.textBoxHDRelatedCompSysInfoServer.Text = "";
                createCaseFormInstance.textBoxHDRelatedCompSysInfoServerType.Text = "";
                createCaseFormInstance.textBoxHDRelatedCompSysInfoVirtualMachine.Text = "";
                createCaseFormInstance.textBoxHDRelatedCompSysInfoHostedSystem.Text = "";
                createCaseFormInstance.textBoxHDRelatedCompSysInfoHostname.Text = "";
            }
            //related raid
            if (thisCaseHardDrive.ReferenceRaid != null)
            {
                createCaseFormInstance.textBoxHDRaidHardwareOrSoftware.Text = thisCaseHardDrive.ReferenceRaid.SoftwareOrHardware.ToString();
                createCaseFormInstance.textBoxHDRaidType.Text = thisCaseHardDrive.ReferenceRaid.RaidType;
                createCaseFormInstance.textBoxHDRaidLevel.Text = thisCaseHardDrive.ReferenceRaid.RaidLevel;
                createCaseFormInstance.listViewRelatedRaidonHDPage.Items.Clear();
                EntitiesToListView.FillHardDrivesListViewMinimalDetailView(thisCaseHardDrive.ReferenceRaid.AssociatedHardDrives, createCaseFormInstance.listViewRelatedRaidonHDPage);
            }
            else
            {
                createCaseFormInstance.textBoxHDRaidHardwareOrSoftware.Text = "";
                createCaseFormInstance.textBoxHDRaidType.Text = "";
                createCaseFormInstance.textBoxHDRaidLevel.Text = "";
                createCaseFormInstance.listViewRelatedRaidonHDPage.Text = "";
                createCaseFormInstance.listViewRelatedRaidonHDPage.Items.Clear();
                createCaseFormInstance.listViewRelatedRaidonHDPage.Columns.Clear();
            }

        }




        public static void ForensicProcesseslistViewToDetailFields(ForensicProcess this_ForensicProcess, Create_Case createCaseFormInstance)
        {

            //collection information
            createCaseFormInstance.textBoxFPCollectionLocationOutput.Text = this_ForensicProcess.CollectionLocation;
            createCaseFormInstance.textBoxFPRoomNumber.Text = this_ForensicProcess.RoomNumber;
            createCaseFormInstance.textBoxFPCustodianOrUser.Text = this_ForensicProcess.CustodianOrUser;
            createCaseFormInstance.textBoxFPPhotosTaken.Text = this_ForensicProcess.PhotoWasTaken.ToString();
            createCaseFormInstance.textBoxFPImageOnly.Text = this_ForensicProcess.WasImageOnly.ToString();
            createCaseFormInstance.textBoxFPHardDriveOnly.Text = this_ForensicProcess.WasHardDriveOnly.ToString();

            //processing information
            createCaseFormInstance.textBoxFPProcessPerformed.Text = this_ForensicProcess.ProcessingPerformed;
            createCaseFormInstance.textBoxFPDeviceUsed.Text = this_ForensicProcess.ForensicDeviceUsed;
            createCaseFormInstance.textBoxFPSoftware.Text = this_ForensicProcess.Software;

            //image information
            createCaseFormInstance.textBoxFPImagesMade.Text = this_ForensicProcess.ImagesMade;
            createCaseFormInstance.textBoxFPImagesVerifiedBy.Text = this_ForensicProcess.ImagesVerifiedBy;

            //cdf info
            createCaseFormInstance.textBoxFPCDFTechExaminer.Text = this_ForensicProcess.CdfInfo.TechExaminer.EmployeeName.FirstName + " " + this_ForensicProcess.CdfInfo.TechExaminer.EmployeeName.LastName;
            createCaseFormInstance.textBoxFPFinishDateTime.Text = this_ForensicProcess.CdfInfo.Cdfdate.ToString();
        }

        public static void listViewFPDestinationMediae(int i, IList<DestinationMedia> caseDestinationMedia, Create_Case createCaseFormInstance)
        {

            //createCaseFormInstance.comboBoxDestinationMedia.Text = caseDestinationMedia[i].Type.ToString();
            //createCaseFormInstance.textBoxBrandOutput.Text = caseDestinationMedia[i].Brand;
            //createCaseFormInstance.txtSerialNum.Text = caseDestinationMedia[i].SerialNumber.ToString();
            //createCaseFormInstance.textBoxSizeOutput.Text = caseDestinationMedia[i].Size.ToString();
        }

    }
}
