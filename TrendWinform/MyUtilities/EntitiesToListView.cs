using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using NHibernate.Linq;
using TrendWinForm.Domain.Entities;
using TrendWinForm.Domain.ValueObjects;
using TrendCustromControls;

namespace TrendWinForm.MyUtilities
{
    class EntitiesToListView
    {
        public static void FillComputersListview(IList<Computer> computers, ListView target)
        {
            target.Items.Clear();
            target.Columns.Clear();
            target.Columns.Add("Make");
            target.Columns.Add("Model");
            target.Columns.Add("Serial");
            target.Columns.Add("SVCTAG");
            target.Columns.Add("Type");
            IList<String> images = new List<string>();
            images.Add("TrendWinForm.Images.Icons.desktop_computer_48.png");
            images.Add("TrendWinForm.Images.Icons.laptop_computer_48.png");
            images.Add("TrendWinForm.Images.Icons.server_computer_48.png");
            images.Add("TrendWinForm.Images.Icons.mobile_computer_48.png");
            images.Add("TrendWinForm.Images.Icons.mystery_computer_48.png");

            PopulateListViewImages(images, target);
            foreach (var comp in computers)
            {
                var item = new ListViewItem(comp.SerialNumber);
                item.Text = comp.Make;
                item.SubItems.Add(comp.Model);
                item.SubItems.Add(comp.SerialNumber);
                item.SubItems.Add(comp.SvcTag);
                item.SubItems.Add(comp.Type);

                if (comp.Type == "Desktop") { item.ImageIndex = 0; }
                else if (comp.Type == "Laptop") { item.ImageIndex = 1; }
                else if (comp.Type == "Server") { item.ImageIndex = 2; }
                else if (comp.Type == "Mobile") { item.ImageIndex = 3; }
                else { item.ImageIndex = 4; }
                target.Items.Add(item);
                target.TileSize = new System.Drawing.Size(140, 52);
            }
        }

        public static void FillComputersListViewDetailView(IList<Computer> computers, ListView target)
        {
            FillComputersListview(computers, target);
            target.View = View.Details;
            target.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            target.Columns[target.Columns.Count - 1].Width = -2;
        }

        public static void FillHardDrivesListView(IList<HardDrive> hardDrives, ListView target)
        {
            target.Items.Clear();
            target.Columns.Clear();
            target.Columns.Add("Make");
            target.Columns.Add("Model");
            target.Columns.Add("Serial ");
            target.Columns.Add("Size [kb]");
            target.Columns.Add("Type");
            target.Columns.Add("Interface");
            target.Columns.Add("Position");
            IList<string> images = new List<string>();
            images.Add("TrendWinForm.Images.Icons.platter_hardDrive_48.png");
            images.Add("TrendWinForm.Images.Icons.solidState_hardDrive_48.png");

            PopulateListViewImages(images, target);
            hardDrives.ForEach(hd =>
                                   {
                                       var item = new ListViewItem(hd.Serial);
                                       item.Text = hd.Make;

                                       item.SubItems.Add(hd.Model);
                                       item.SubItems.Add(hd.Serial);
                                       item.SubItems.Add(hd.SizeInKilobytes.ToString());
                                       item.SubItems.Add(hd.Type);
                                       item.SubItems.Add(hd.DriveInterface);
                                       item.SubItems.Add(hd.DrivePosition);

                                       if (hd.Type == "Disk Drive") { item.ImageIndex = 0; }
                                       else { item.ImageIndex = 1; }
                                       target.Items.Add(item);
                                   });
            target.TileSize = new System.Drawing.Size(140, 52);
        }

        public static void FillHardDrivesListViewDetailView(IList<HardDrive> hardDrives, ListView target)
        {
            FillHardDrivesListView(hardDrives, target);
            target.View = View.Details;
            target.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            target.Columns[target.Columns.Count - 1].Width = -2;
        }


        public static void FillRaidsListView(IList<Raid> raids, ListView target)
        {
            target.Items.Clear();
            target.Columns.Clear();
            target.Columns.Add("Level");
            target.Columns.Add("S/H");
            target.Columns.Add("Type");

            raids.ForEach(r =>
            {
                var item = new ListViewItem(r.RaidLevel);
                item.Text = r.RaidLevel;
                if (r.SoftwareOrHardware == TrendWinForm.Domain.Entities.RaidType.Hardware)
                {
                    item.SubItems.Add("Hardware");
                }
                else
                {
                    item.SubItems.Add("Software");
                }
                item.SubItems.Add(r.RaidType);
                target.Items.Add(item);
            });
        }

        public static void FillHardRaidsListViewDetailView(IList<Raid> raids, ListView target)
        {
            FillRaidsListView(raids, target);
            target.View = View.Details;
            target.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            target.Columns[target.Columns.Count - 1].Width = -2;
        }

        public static void FillForensicProcessListView(IList<ForensicProcess> forensicProcesses, ListView target)
        {
            target.Items.Clear();
            target.Columns.Clear();
            target.Columns.Add("Collection Location");
            target.Columns.Add("Room Number");
            target.Columns.Add("Processing Performed");
            target.Columns.Add("Software");


            IList<String> images = new List<string>();
            images.Add("TrendWinForm.Images.Icons.magnifyinglass-large_48.png");
            PopulateListViewImages(images, target);
            forensicProcesses.ForEach(fp =>
                                          {
                                              var item = new ListViewItem(fp.CollectionLocation);
                                              item.Text = fp.CollectionLocation;
                                              item.SubItems.Add(fp.RoomNumber);
                                              item.SubItems.Add(fp.ProcessingPerformed);
                                              item.SubItems.Add(fp.Software);

                                              item.ImageIndex = 0;
                                              target.Items.Add(item);
                                          }

                );

            target.TileSize = new System.Drawing.Size(140, 52);
        }
        public static void FillForensicProcessListViewDetailView(IList<ForensicProcess> forensicProcesses, ListView target)
        {
            FillForensicProcessListView(forensicProcesses, target);
            target.View = View.Details;
            target.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            target.Columns[target.Columns.Count - 1].Width = -2;
        }


        public static void FillDestinationMediaListView(IList<DestinationMedia> destinationMediae, ListView target)
        {
            target.Items.Clear();
            target.Columns.Clear();
            target.Columns.Add("Type");
            target.Columns.Add("Brand");
            target.Columns.Add("Size");
            target.Columns.Add("Serial Number");
            IList<String> images = new List<string>();
            images.Add("TrendWinForm.Images.Icons.DVD_48.png");
            PopulateListViewImages(images, target);
            destinationMediae.ForEach(dm =>
                                          {
                                              var item = new ListViewItem(dm.SerialNumber);
                                              item.Text = dm.Type;
                                              item.SubItems.Add(dm.Brand);
                                              item.SubItems.Add(dm.Size.ToString());
                                              item.ImageIndex = 0;
                                              target.Items.Add(item);
                                          }
                );

        }

        public static void FillDestinationMediaListViewDetailView(IList<DestinationMedia> destinationMediae, ListView target)
        {
            FillDestinationMediaListView(destinationMediae, target);
            target.View = View.Details;
            target.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            target.Columns[target.Columns.Count - 1].Width = -2;
        }

        public static void PopulateListViewImages(IList<String> resourceLocations, ListView target)
        {
            target.View = View.Tile;

            ImageList smallImagelist = new ImageList();
            smallImagelist.ImageSize = new System.Drawing.Size(32, 32);
            smallImagelist.ColorDepth = ColorDepth.Depth32Bit;
            ImageList largeImagelist = new ImageList();
            largeImagelist.ImageSize = new System.Drawing.Size(48, 48);
            largeImagelist.ColorDepth = ColorDepth.Depth32Bit;
            foreach (var image in resourceLocations)
            {
                Assembly myAssembly = Assembly.GetExecutingAssembly();
                Stream myStream = myAssembly.GetManifestResourceStream(image);
                Bitmap img = new Bitmap(myStream);

                largeImagelist.Images.Add(img);
                smallImagelist.Images.Add(img);
            }

            target.LargeImageList = largeImagelist;
            target.SmallImageList = smallImagelist;


        }

        public static void FillActiveUserFilesListView(IList<ActiveUserFile> activeUserFiles, ListView target)
        {
            target.Items.Clear();
            target.Columns.Clear();
            target.Columns.Add("File Name");
            target.Columns.Add("Reference Computer");
            target.Columns.Add("Memory Use");
            target.Columns.Add("CPU Use");
            target.Columns.Add("Description");

            IList<String> images = new List<string>();
            images.Add("TrendWinForm.Images.Icons.File_byJesse_48.png");
            PopulateListViewImages(images, target);
            activeUserFiles.ForEach(auf =>
            {
                var item = new ListViewItem(auf.ReferenceComputer.ToString());
                item.Text = auf.FileName;
                item.SubItems.Add(auf.ReferenceComputer.Make + " " + auf.ReferenceComputer.Model);
                item.SubItems.Add(auf.MemoryUsage.ToString());
                item.SubItems.Add(auf.CpuUsage.ToString());
                item.SubItems.Add(auf.Description);
                item.ImageIndex = 0;
                target.Items.Add(item);
            });
        }


        public static void FillActiveUserFilesListViewDetailView(IList<ActiveUserFile> activeUserFiles, ListView target)
        {
            FillActiveUserFilesListView(activeUserFiles, target);
            target.View = View.Details;
            target.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            target.Columns[target.Columns.Count - 1].Width = -2;
        }



        public static void FillCasesListView(IList<Case> cases, ListView target)
        {
            target.Items.Clear();
            target.Columns.Clear();
            
            target.Columns.Add("Case Matter");
            target.Columns.Add("Date");
            target.Columns.Add("Case Number");
            target.Columns.Add("Case Item Number");
            target.Columns.Add("Firm");
            target.Columns.Add("Requester");
            target.Columns.Add("Examiner");
            target.Columns.Add("# Computers");
            target.Columns.Add("# Hard Drives");
            target.Columns.Add("# Forensics");
            target.Columns.Add("# Files");

            IList<String> images = new List<string>();
            images.Add("TrendWinForm.Images.Icons.briefcase_closed_48x48.png");
            images.Add("TrendWinForm.Images.Icons.briefcase_open_48x48.png");
            PopulateListViewImages(images, target);

            cases.ForEach(x =>
            {
                var item = new ListViewItem(x.Id.ToString());

                
                
                item.Text = x.Matter;
                item.SubItems.Add(x.StartDate.ToString());


                item.SubItems.Add(Math.Truncate(x.CaseNumber).ToString());
                item.SubItems.Add(x.ItemNumber.ToString());
                item.SubItems.Add(x.Firm.FirmName.ToString());
                item.SubItems.Add(x.Requester.Name.LastName.ToString() +" , " +x.Requester.Name.FirstName.ToString());
                item.SubItems.Add(x.Examiner.EmployeeName.LastName.ToString() + " , " + x.Examiner.EmployeeName.FirstName.ToString());
                item.SubItems.Add(x.Computers.Count().ToString());
                item.SubItems.Add(x.HardDrives.Count().ToString());
                item.SubItems.Add(x.ForensicProcesses.Count().ToString());
                item.SubItems.Add(x.ActiveUserFiles.Count().ToString());

                item.Tag = x.Id;

                item.ImageIndex = 1;
                item.ToolTipText = x.NotesAndConclusion.Notes;
                target.Items.Add(item);
            });
        }


        public static void FillCasesListViewDetailView(IList<Case> cases, ListView target)
        {
            FillCasesListView(cases, target);
            target.View = View.Details;
            target.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            target.Columns[target.Columns.Count - 1].Width = -2;
        }



    }
}
