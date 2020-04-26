using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlmApiClient
{
    public partial class ClientApiForm : Form
    {
        public ClientApiForm()
        {
            InitializeComponent();

            // Common list of routes, not comprehensive
            cboApiCall.DataSource = new List<RoutedItem>()
            {
                new RoutedItem("/Sport", "All Sports"),
                new RoutedItem("/Sport/1", "    Baseball"),
                new RoutedItem("/Sport/2", "    Basketball"),
                new RoutedItem("/Sport/3", "    Football"),
                new RoutedItem("/Sport/4", "    Hockey"),
                new RoutedItem("/Sport/6", "    Golf"),
                new RoutedItem("/Sport/7", "    Auto Racing"),
                new RoutedItem("/Sport/8", "    Soccer"),
                new RoutedItem("/Sport/9", "    Tennis"),
                new RoutedItem("/Sport/10", "    Fighting"),
                new RoutedItem("/Sport/11", "    eSports"),
                new RoutedItem("/Sport/12", "    General Sports"),
                new RoutedItem("/League", "All Leagues"),
                new RoutedItem("/League/1", "    MLB"),
                new RoutedItem("/League/26", "    NBA"),
                new RoutedItem("/League/30", "    NFL"),
                new RoutedItem("/League/40", "    NHL"),
                new RoutedItem("/League/50", "    PGA"),
                new RoutedItem("/League/60", "    NAS"),
                new RoutedItem("/League/72", "    MLS"),
                new RoutedItem("/League/100", "    ATP"),
                new RoutedItem("/League/110", "    UFC"),
                new RoutedItem("/League/120", "    Gaming"),
                new RoutedItem("/League/150", "    Other"),
                new RoutedItem("/StoryType", "All StoryTypes"),
                new RoutedItem("/Story/1", "MLB Stories"),
                new RoutedItem("/Story/26", "NBA Stories"),
                new RoutedItem("/Story/30", "NFL Stories"),
                new RoutedItem("/Story/40", "NHL Stories"),
                new RoutedItem("/Game/1", "MLB Games")
            };
        }

        private void cmdGetResults_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Enabled = false;

                var item = cboApiCall.SelectedItem as RoutedItem;
                WriteToOutput($"Getting results for {item.DisplayText}", true);

                Application.DoEvents();

                WriteToOutput(GetClient().GetResponse(item.Route));

            }
            catch (Exception ex)
            {
                WriteToOutput($"Error getting results{Environment.NewLine}{ex.Message}");
            }
            finally
            {
                Cursor = Cursors.Default;
                Enabled = true;
            }
        }

        private IFlmClient GetClient()
        {
            if (Guid.TryParse(txtApiKey.Text.Trim(), out Guid apiKey)
                && apiKey != Guid.Empty)
            {
                return new FlmClient(new RestClientFactory(), apiKey);
            }

            throw new ArgumentException($"The api key must be a non-empty guid: {txtApiKey.Text}");
        }

        private void WriteToOutput(string message, bool clearContents = false)
        {
            if (clearContents)
            {
                txtResults.Text = string.Empty;
            }

            txtResults.Text += $"{message}{Environment.NewLine}";
        }
    }
}
