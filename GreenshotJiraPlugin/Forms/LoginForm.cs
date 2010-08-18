/*
 * Greenshot - a free and open source screenshot tool
 * Copyright (C) 2007-2010  Thomas Braun, Jens Klingen, Robin Krom
 * 
 * For more information see: http://getgreenshot.org/
 * The Greenshot project is hosted on Sourceforge: http://sourceforge.net/projects/greenshot/
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 1 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

using Greenshot.Core;

namespace GreenshotJiraPlugin {
	/// <summary>
	/// Description of PasswordRequestForm.
	/// </summary>
	public partial class LoginForm : Form {
		private ILanguage lang = Language.GetInstance();

		public LoginForm() {
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			InitializeTexts();
		}
				
		private void InitializeTexts() {
			this.label_url.Text = lang.GetString(LangKey.label_url);
			this.label_user.Text = lang.GetString(LangKey.label_user);
			this.label_password.Text = lang.GetString(LangKey.label_password);
			this.buttonOK.Text = lang.GetString(LangKey.OK);
			this.buttonCancel.Text = lang.GetString(LangKey.CANCEL);
			this.checkBoxDoNotStorePassword.Text = lang.GetString(LangKey.label_no_password_store);
			this.Text = lang.GetString(LangKey.login_title);
		}

		public string Url {
			get {return textBoxUrl.Text;}
			set {textBoxUrl.Text = value;}
		}

		public string User {
			get {return textBoxUser.Text;}
			set {textBoxUser.Text = value;}
		}

		public string Password {
			get {return textBoxPassword.Text;}
			set {textBoxPassword.Text = value;}
		}

		public bool DoNotStorePassword {
			get {return checkBoxDoNotStorePassword.Checked;}
			set {checkBoxDoNotStorePassword.Checked = value;}
		}

		void ButtonOKClick(object sender, EventArgs e) {
			this.DialogResult = DialogResult.OK;
		}
		
		void ButtonCancelClick(object sender, System.EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
		}

		void TextBoxPasswordKeyUp(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				this.DialogResult = DialogResult.OK;
			}
		}
	}
}
