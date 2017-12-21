using System;
using System.Collections.Generic;
using ICT13580067FinalA.Models;
using Xamarin.Forms;

namespace ICT13580067FinalA
{
    public partial class Profile1 : ContentPage
    {
        Profile profile;
        public Profile1(Profile profile = null)
        {
            InitializeComponent();
            this.profile = profile;
            titleLabel.Text = profile == null ? "กรอกข้อมูล" : "แก้ไขข้อมูล";

            saveButton.Clicked += SaveButton_Clicked;
            cancelButton.Clicked += CancelButton_Clicked;
               
                sexPicker.Items.Add("ชาย");
            sexPicker.Items.Add("หญิง");


            zonePicker.Items.Add("ฝ่ายประชาสัมพันธ์");
            zonePicker.Items.Add("ฝ่ายออกแบบ");
            zonePicker.Items.Add("ฝ่ายIT");
            zonePicker.Items.Add("ฝ่ายบัญชี");

            marPicker.Items.Add("โสด");
            marPicker.Items.Add("แต่งงานแล้ว");
            marPicker.Items.Add("หย่าร้าง");
            marPicker.Items.Add("แยกกันอยู่");

            if (profile != null)
            {
                nameEntry.Text = profile.Name;
                lastEntry.Text = profile.Last;
                ageEntry.Text = profile.Age.ToString();
                sexPicker.SelectedItem = profile.Sex;
                zonePicker.SelectedItem = profile.Zone;
                telEntry.Text = profile.Tel.ToString();
                mailEntry.Text = profile.Mail.ToString();
                addEditor.Text = profile.Add;

            }
        }
        void SaveButton_Clicked(object sender, EventArgs e)
        {

        }
        void CancelButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
