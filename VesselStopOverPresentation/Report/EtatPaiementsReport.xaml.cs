﻿using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Reporting.WinForms;

namespace VesselStopOverPresentation
{
    /// <summary>
    /// Logique d'interaction pour EtatPaiementsReport.xaml
    /// </summary>
    public partial class EtatPaiementsReport : DockPanel
    {
        private ReportingControlPanel reportPanel;

        public EtatPaiementsReport(ReportingControlPanel panel)
        {
            try
            {
                InitializeComponent();
                reportPanel = panel;

                repViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
                repViewer.ServerReport.ReportServerUrl = new Uri("http://192.168.0.28/ReportServer");
                repViewer.ServerReport.ReportPath = "/VSOMReports/EtatPaiements";

                NetworkCredential myCred = new NetworkCredential("novareports", "novareports", "siege.local");
                repViewer.ServerReport.ReportServerCredentials.NetworkCredentials = myCred;

                ReportParameter[] parameters = new ReportParameter[1];
                parameters[0] = new ReportParameter("RefUser", reportPanel.GetUser().LU.ToString());
                repViewer.ServerReport.SetParameters(parameters);
                repViewer.ServerReport.Refresh();
                repViewer.RefreshReport();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Echec de l'opération !", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
