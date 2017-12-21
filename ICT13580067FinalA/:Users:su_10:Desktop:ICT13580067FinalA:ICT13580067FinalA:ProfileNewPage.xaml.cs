using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580067FinalA
{
    public partial class Profile : ContentPage
    {
        public Profile

        {
            InitializeComponent();

            saveButton.Clicked += SaveButton_Clicked()
                cancelButton.Clicked += CancelButton_Clicked()

            sexPicker.Items.Add("ชาย");
            sexPicker.Items.Add("หญิง");


            zonePicker.Items.Add("ฝ่ายประชาสัมพันธ์");
            zonePicker.Items.Add("ฝ่ายออกแบบ");
            zonePicker.Items.Add("ฝ่ายIT");
            zonePicker.Items.Add("ฝ่ายบัญชี");

            marPicker.Items.Add("โสด");
            marPicker.Items.Add("แต่งงานแล้ว");
            marPicker.Items.Add("หย่าร้าง");
            marryPicker.Items.Add("แยกกันอยู่");
        }
        void SaveButton_Clicked(object sender, EventArgs e)
        {
            
        }
        void CancelButton_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}
