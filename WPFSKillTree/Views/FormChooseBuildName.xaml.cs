﻿using System;
using System.Windows;
using MahApps.Metro.Controls;
using POESKillTree.ViewModels;

namespace POESKillTree.Views
{
    /// <summary>
    /// Interaction logic for FormChooseBuildName.xaml
    /// </summary>
    public partial class FormChooseBuildName : MetroWindow
    {
        public FormChooseBuildName()
        {
            InitializeComponent();
        }
        public FormChooseBuildName(string characterName, string accountName, string itemData)
        {
            InitializeComponent();
            txtCharacterName.Text = characterName;
            txtAccountName.Text = accountName;
            txtItemData.Text = itemData;
        }
        public FormChooseBuildName(PoEBuild selectedBuild)
        {
            InitializeComponent();
            txtName.Text = selectedBuild.Name;
            txtName2.Text = selectedBuild.Note;
            txtCharacterName.Text = selectedBuild.CharacterName;
            txtAccountName.Text = selectedBuild.AccountName;
            txtItemData.Text = selectedBuild.ItemData;
            lblLastUpdated.Content = "Last updated: " +
                                     (selectedBuild.LastUpdated == DateTime.MinValue ? "Not Available" : selectedBuild.LastUpdated.ToString());
            txtName.Select(txtName.Text.Length, 0);
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        public string GetBuildName()
        {
            return txtName.Text;
        }
        public string GetNote()
        {
            return txtName2.Text;
        }
        public string GetCharacterName()
        {
            return txtCharacterName.Text;
        }
        public string GetAccountName()
        {
            return txtAccountName.Text;
        }
        public string GetItemData()
        {
            return txtItemData.Text;
        }
        private void FormChooseBuildName_Loaded(object sender, RoutedEventArgs e)
        {
            txtName.Focus();
        }
    }
}
