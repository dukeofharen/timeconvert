using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeConvert
{
    public partial class Main : Form
    {
        private DateTime dateTime;
        private TimeZoneInfo currentTimeZone;

        private class ComboItem
        {
            public string Name { get; set; }
            public TimeZoneInfo Info { get; set; }
            public ComboItem(string Name, TimeZoneInfo Info)
            {
                this.Name = Name;
                this.Info = Info;
            }
            public override string ToString()
            {
                return this.Name;
            }
        }

        public Main()
        {
            InitializeComponent();
            InitForm();
            Init();
        }

        private void Init()
        {
            dateTime = DateTime.Now;
            UpdateFields();
        }

        private void InitForm()
        {
            currentTimeZone = TimeZoneInfo.Local;
            timeZoneLabel.Text = currentTimeZone.DisplayName;
        }

        private void unixTimestamp_Leave(object sender, EventArgs e)
        {
            string unixTimeString = unixTimestamp.Text;
            int unixTimestampSeconds = 0;
            if (int.TryParse(unixTimeString, out unixTimestampSeconds) && unixTimeString.Length > 0)
            {
                dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                dateTime = dateTime.AddSeconds(unixTimestampSeconds);
                UpdateFields();
            }
        }

        private void regularDateTime_Leave(object sender, EventArgs e)
        {
            string regularDateString = regularDateTime.Text;
            if (regularDateString != string.Empty)
            {
                try
                {
                    dateTime = DateTime.ParseExact(regularDateString, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                    UpdateFields();
                }
                catch { }
            }
        }

        private void UpdateFields()
        {
            if (dateTime != null)
            {
                
                DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                TimeSpan span = (dateTime - epoch);

                unixTimestamp.Text = ((int)span.TotalSeconds).ToString();

                int offset = (int)currentTimeZone.GetUtcOffset(dateTime).TotalSeconds;
                regularDateTime.Text = dateTime.ToString("yyyy-MM-dd HH:mm:ss");

                humanDateString.Text = dateTime.ToString("F");
            }
        }

        private void nowButton_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Duco Winterwerp 2014\nwww.12duc.net\nIcon by hopstarter (iconarchive.com)", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
