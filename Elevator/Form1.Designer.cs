namespace Elevator
{
    partial class frmBuilding
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFloors = new TextBox();
            label1 = new Label();
            btnCreateBuilding = new Button();
            btnDrills = new Button();
            messageList = new ListBox();
            SuspendLayout();
            // 
            // txtFloors
            // 
            txtFloors.Location = new Point(111, 31);
            txtFloors.Name = "txtFloors";
            txtFloors.ReadOnly = true;
            txtFloors.Size = new Size(62, 23);
            txtFloors.TabIndex = 0;
            txtFloors.Text = "6";
            txtFloors.TextAlign = HorizontalAlignment.Center;
            txtFloors.KeyPress += txtFloors_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 39);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Pisos";
            // 
            // btnCreateBuilding
            // 
            btnCreateBuilding.Location = new Point(36, 77);
            btnCreateBuilding.Name = "btnCreateBuilding";
            btnCreateBuilding.Size = new Size(137, 23);
            btnCreateBuilding.TabIndex = 2;
            btnCreateBuilding.Text = "Crear Edificio";
            btnCreateBuilding.UseVisualStyleBackColor = true;
            btnCreateBuilding.Click += btnCreateBuilding_Click;
            // 
            // btnDrills
            // 
            btnDrills.Location = new Point(36, 138);
            btnDrills.Name = "btnDrills";
            btnDrills.Size = new Size(137, 23);
            btnDrills.TabIndex = 3;
            btnDrills.Text = "Simular";
            btnDrills.UseVisualStyleBackColor = true;
            btnDrills.Visible = false;
            btnDrills.Click += btnDrills_Click;
            // 
            // messageList
            // 
            messageList.FormattingEnabled = true;
            messageList.ItemHeight = 15;
            messageList.Location = new Point(29, 192);
            messageList.Name = "messageList";
            messageList.Size = new Size(374, 199);
            messageList.TabIndex = 4;
            messageList.Visible = false;
            // 
            // frmBuilding
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 450);
            Controls.Add(messageList);
            Controls.Add(btnDrills);
            Controls.Add(btnCreateBuilding);
            Controls.Add(label1);
            Controls.Add(txtFloors);
            Name = "frmBuilding";
            Text = "Edificio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFloors;
        private Label label1;
        private Button btnCreateBuilding;
        private Button btnDrills;
        private ListBox messageList;
    }
}
