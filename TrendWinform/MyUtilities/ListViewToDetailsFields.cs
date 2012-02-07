using System;
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
        public static void ComputerlistViewToDetailFields(int i, IList<Computer> caseComputers, Create_Case createCaseFormInstance)
        {
            //general information
            createCaseFormInstance.txtMakeOutput.Text = caseComputers[i].Make;
            createCaseFormInstance.txtModelOutput.Text = caseComputers[i].Model;
            createCaseFormInstance.txtTypeOutput.Text = caseComputers[i].Type;
            createCaseFormInstance.txtSerialNum.Text = caseComputers[i].SerialNumber;
            createCaseFormInstance.txtSvcTag.Text = caseComputers[i].SvcTag;

            //cmos settings
            createCaseFormInstance.txtCMOSDate.Text = caseComputers[i].CmosDate.Date.ToString();
            createCaseFormInstance.txtCMOSTime.Text = caseComputers[i].CmosDate.TimeOfDay.ToString();
            createCaseFormInstance.txtActualDate.Text = caseComputers[i].CmosDate.Date.ToString();
            createCaseFormInstance.txtActualTime.Text = caseComputers[i].CmosDate.TimeOfDay.ToString();
            createCaseFormInstance.txtTimeProvidedBy.Text = caseComputers[i].ActualTimeProvidedBy;
            createCaseFormInstance.txtSetupKeystroke.Text = caseComputers[i].KeystrokeForCmosSetup;
            createCaseFormInstance.txtWasCMOSChanged.Text = caseComputers[i].CmosWasChanged.ToString();
            createCaseFormInstance.txtCMOSChangesMade.Text = caseComputers[i].DescriptionOfCmosChanges;

            //sys info
            createCaseFormInstance.txtSystemRunning.Text = caseComputers[i].SystemWasRunning.ToString(); //bool
            createCaseFormInstance.txtPulledPlug.Text = caseComputers[i].PlugWasPulled.ToString(); //bool
            createCaseFormInstance.txtAppsRunning.Text = caseComputers[i].AppsWereRunning.ToString();
            createCaseFormInstance.txtShutDownBy.Text = caseComputers[i].WhoShutDown.ToString();
            createCaseFormInstance.txtWasItPoweredOn.Text = caseComputers[i].WasPoweredOn.ToString();
            createCaseFormInstance.txtWasItAServer.Text = caseComputers[i].WasServer.ToString();
            createCaseFormInstance.txtServerType.Text = caseComputers[i].ServerType;
            createCaseFormInstance.txtVirtualMachine.Text = caseComputers[i].WasVirtualMachine.ToString();
            createCaseFormInstance.txtHostedSystem.Text = caseComputers[i].WasHostedSystem.ToString();
            createCaseFormInstance.txtHostname.Text = caseComputers[i].Hostname;

            //HD information




            //cdfi info
            createCaseFormInstance.txtTechExaminer.Text = caseComputers[i].CdfInfo.TechExaminer.EmployeeName.FirstName.ToString() + " " + caseComputers[i].CdfInfo.TechExaminer.EmployeeName.LastName.ToString();
            createCaseFormInstance.txtFinishDateTime.Text = caseComputers[i].CdfInfo.Cdfdate.ToString();




        }

        private static Color setJumperBackgroundColor(int val)
        {
            switch (val)
            {

                case 1:
                    return Color.Lime;
                    break;
                case 2:
                    return Color.Red;
                    break;
                case 3:
                    return Color.Aqua;
                    break;
                case 4:
                    return Color.Yellow;
                    break;
                case 5:
                    return Color.FromArgb(64, 64, 64);
                    break;
                default:
                    return Color.White;
                    break;
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
        public static void HardDrivelistViewToDetailFields(int i, IList<HardDrive> caseHardDrives, Create_Case createCaseFormInstance)
        {




            //hard drive details
            createCaseFormInstance.textBoxHDMakeOutput.Text = caseHardDrives[i].Make;
            createCaseFormInstance.textBoxHDModelOutput.Text = caseHardDrives[i].Model;
            createCaseFormInstance.textBoxHDTypeOutput.Text = caseHardDrives[i].Type;
            createCaseFormInstance.textBoxHDSerialNumOutput.Text = caseHardDrives[i].Serial;
            createCaseFormInstance.textBoxHDSizeOutput.Text = caseHardDrives[i].SizeInKilobytes.ToString();
            createCaseFormInstance.textBoxHDDriveInterfaceOutput.Text = caseHardDrives[i].DriveInterface;
            createCaseFormInstance.textBoxHDDrivePositionOutput.Text = caseHardDrives[i].DrivePosition;
            createCaseFormInstance.textBoxHDJumperSettingsOutput.Text = caseHardDrives[i].JumperSetting;

            //jumper details
            resetjumpeerBackgroundColors(createCaseFormInstance);
            createCaseFormInstance.jumperPosition0.BackColor = setJumperBackgroundColor(caseHardDrives[i].JumperDiagram.Jumper_0);
            createCaseFormInstance.jumperPosition1.BackColor = setJumperBackgroundColor(caseHardDrives[i].JumperDiagram.Jumper_1);
            createCaseFormInstance.jumperPosition2.BackColor = setJumperBackgroundColor(caseHardDrives[i].JumperDiagram.Jumper_2);
            createCaseFormInstance.jumperPosition3.BackColor = setJumperBackgroundColor(caseHardDrives[i].JumperDiagram.Jumper_3);
            createCaseFormInstance.jumperPosition4.BackColor = setJumperBackgroundColor(caseHardDrives[i].JumperDiagram.Jumper_4);
            createCaseFormInstance.jumperPosition5.BackColor = setJumperBackgroundColor(caseHardDrives[i].JumperDiagram.Jumper_5);
            createCaseFormInstance.jumperPosition6.BackColor = setJumperBackgroundColor(caseHardDrives[i].JumperDiagram.Jumper_6);
            createCaseFormInstance.jumperPosition7.BackColor = setJumperBackgroundColor(caseHardDrives[i].JumperDiagram.Jumper_7);
            createCaseFormInstance.jumperPosition8.BackColor = setJumperBackgroundColor(caseHardDrives[i].JumperDiagram.Jumper_8);
            createCaseFormInstance.jumperPosition9.BackColor = setJumperBackgroundColor(caseHardDrives[i].JumperDiagram.Jumper_9);

            //cdf info
            createCaseFormInstance.textBoxHDTechExaminerOutput.Text = caseHardDrives[i].CDFInfo.TechExaminer.EmployeeName.FirstName + " " + caseHardDrives[i].CDFInfo.TechExaminer.EmployeeName.LastName.ToString();
            createCaseFormInstance.textBoxHDFinishDateTimeOutput.Text = caseHardDrives[i].CDFInfo.Cdfdate.ToString();
            //related computer/reference computer
            if (caseHardDrives[i].ReferenceComputer != null)
            {
                createCaseFormInstance.textBoxHDRelatedComputerMake.Text = caseHardDrives[i].ReferenceComputer.Make;
                createCaseFormInstance.textBoxHDRelatedComputerModel.Text = caseHardDrives[i].ReferenceComputer.Model;
                createCaseFormInstance.textBoxHDRelatedComputerType.Text = caseHardDrives[i].ReferenceComputer.Type;
                createCaseFormInstance.textBoxHDRelatedComputerSerialNum.Text = caseHardDrives[i].ReferenceComputer.SerialNumber;
                createCaseFormInstance.textBoxHDRelatedComputerSvcTag.Text = caseHardDrives[i].ReferenceComputer.SvcTag;
                createCaseFormInstance.textBoxHDRelatedCompSysInfoSystemRunning.Text = caseHardDrives[i].ReferenceComputer.SystemWasRunning.ToString();
                createCaseFormInstance.textBoxHDRelatedCompSysInfoPulledPlug.Text = caseHardDrives[i].ReferenceComputer.PlugWasPulled.ToString();
                createCaseFormInstance.textBoxHDRelatedCompSysInfoAppsRunning.Text = caseHardDrives[i].ReferenceComputer.AppsWereRunning.ToString();
                createCaseFormInstance.textBoxHDRelatedCompSysInfoShutDownBy.Text = caseHardDrives[i].ReferenceComputer.WhoShutDown.EmployeeName.FirstName.ToString() + " " + caseHardDrives[i].ReferenceComputer.WhoShutDown.EmployeeName.LastName.ToString();
                createCaseFormInstance.textBoxHDRelatedCompSysInfoPoweredOn.Text = caseHardDrives[i].ReferenceComputer.WasPoweredOn.ToString();
                createCaseFormInstance.textBoxHDRelatedCompSysInfoServer.Text = caseHardDrives[i].ReferenceComputer.WasServer.ToString();
                createCaseFormInstance.textBoxHDRelatedCompSysInfoServerType.Text = caseHardDrives[i].ReferenceComputer.ServerType;
                createCaseFormInstance.textBoxHDRelatedCompSysInfoVirtualMachine.Text = caseHardDrives[i].ReferenceComputer.WasVirtualMachine.ToString();
                createCaseFormInstance.textBoxHDRelatedCompSysInfoHostedSystem.Text = caseHardDrives[i].ReferenceComputer.WasHostedSystem.ToString();
                createCaseFormInstance.textBoxHDRelatedCompSysInfoHostname.Text = caseHardDrives[i].ReferenceComputer.Hostname;


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


                if (caseHardDrives[i].ReferenceComputer.Type == "Desktop")
                {
                    createCaseFormInstance.pictureBoxRelatedComputer.Image = computerImageList.Images[0];
                }
                else if (caseHardDrives[i].ReferenceComputer.Type == "Laptop")
                {
                    createCaseFormInstance.pictureBoxRelatedComputer.Image = computerImageList.Images[1];
                }
                else if (caseHardDrives[i].ReferenceComputer.Type == "Server")
                {
                    createCaseFormInstance.pictureBoxRelatedComputer.Image = computerImageList.Images[2];
                }
                else if (caseHardDrives[i].ReferenceComputer.Type == "Mobile")
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
            if (caseHardDrives[i].ReferenceRaid != null)
            {
                createCaseFormInstance.textBoxHDRaidHardwareOrSoftware.Text = caseHardDrives[i].ReferenceRaid.SoftwareOrHardware.ToString();
                createCaseFormInstance.textBoxHDRaidType.Text = caseHardDrives[i].ReferenceRaid.RaidType;
                createCaseFormInstance.textBoxHDRaidLevel.Text = caseHardDrives[i].ReferenceRaid.RaidLevel;
                createCaseFormInstance.listViewRelatedRaidonHDPage.Text = caseHardDrives[i].ReferenceRaid.AssociatedHardDrives.ToString();
            }
            else
            {
                createCaseFormInstance.textBoxHDRaidHardwareOrSoftware.Text = "";
                createCaseFormInstance.textBoxHDRaidType.Text = "";
                createCaseFormInstance.textBoxHDRaidLevel.Text = "";
                createCaseFormInstance.listViewRelatedRaidonHDPage.Text = "";
            }

        }




        public static void ForensicProcesseslistViewToDetailFields(int i, IList<ForensicProcess> caseForensicProcess, Create_Case createCaseFormInstance)
        {

            //collection information
            createCaseFormInstance.textBoxFPCollectionLocationOutput.Text = caseForensicProcess[i].CollectionLocation.ToString();
            createCaseFormInstance.textBoxFPRoomNumber.Text = caseForensicProcess[i].RoomNumber.ToString();
            createCaseFormInstance.textBoxFPCustodianOrUser.Text = caseForensicProcess[i].CustodianOrUser.ToString();
            createCaseFormInstance.textBoxFPPhotosTaken.Text = caseForensicProcess[i].PhotoWasTaken.ToString();
            createCaseFormInstance.textBoxFPImageOnly.Text = caseForensicProcess[i].WasImageOnly.ToString();
            createCaseFormInstance.textBoxFPHardDriveOnly.Text = caseForensicProcess[i].WasHardDriveOnly.ToString();

            //processing information
            createCaseFormInstance.textBoxFPProcessPerformed.Text = caseForensicProcess[i].ProcessingPerformed.ToString();
            createCaseFormInstance.textBoxFPDeviceUsed.Text = caseForensicProcess[i].ForensicDeviceUsed.ToString();
            createCaseFormInstance.textBoxFPSoftware.Text = caseForensicProcess[i].Software.ToString();

            //image information
            createCaseFormInstance.textBoxFPImagesMade.Text = caseForensicProcess[i].ImagesMade.ToString();
            createCaseFormInstance.textBoxFPImagesVerifiedBy.Text = caseForensicProcess[i].ImagesVerifiedBy.ToString();

            //cdf info
            createCaseFormInstance.textBoxFPCDFTechExaminer.Text = caseForensicProcess[i].CdfInfo.TechExaminer.EmployeeName.FirstName.ToString() + " " + caseForensicProcess[i].CdfInfo.TechExaminer.EmployeeName.LastName.ToString();
            createCaseFormInstance.textBoxFPFinishDateTime.Text = caseForensicProcess[i].CdfInfo.Cdfdate.ToString();
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
