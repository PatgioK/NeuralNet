namespace NeuralNetwork
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadNetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.numberPanel = new System.Windows.Forms.Panel();
            this.drawPanel = new NeuralNetwork.GUI.DrawPanel();
            this.correctLabel = new System.Windows.Forms.Label();
            this.drawPanelLabel = new System.Windows.Forms.Label();
            this.numToDrawLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.prevGuessLabel = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.numberPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1000, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadNetMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadNetMenuItem
            // 
            this.loadNetMenuItem.Name = "loadNetMenuItem";
            this.loadNetMenuItem.Size = new System.Drawing.Size(75, 26);
            // 
            // mainContainer
            // 
            this.mainContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.mainContainer.ColumnCount = 2;
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainContainer.Controls.Add(this.numberPanel, 1, 0);
            this.mainContainer.Controls.Add(this.panel2, 0, 0);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 26);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.RowCount = 1;
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 643F));
            this.mainContainer.Size = new System.Drawing.Size(1000, 644);
            this.mainContainer.TabIndex = 2;
            // 
            // numberPanel
            // 
            this.numberPanel.BackColor = System.Drawing.SystemColors.Control;
            this.numberPanel.Controls.Add(this.drawPanel);
            this.numberPanel.Controls.Add(this.correctLabel);
            this.numberPanel.Controls.Add(this.drawPanelLabel);
            this.numberPanel.Controls.Add(this.numToDrawLabel);
            this.numberPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberPanel.Location = new System.Drawing.Point(503, 4);
            this.numberPanel.Name = "numberPanel";
            this.numberPanel.Size = new System.Drawing.Size(493, 636);
            this.numberPanel.TabIndex = 0;
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawPanel.Location = new System.Drawing.Point(19, 126);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(455, 384);
            this.drawPanel.TabIndex = 3;
            // 
            // correctLabel
            // 
            this.correctLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.correctLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLabel.Location = new System.Drawing.Point(0, 31);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(493, 30);
            this.correctLabel.TabIndex = 2;
            this.correctLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // drawPanelLabel
            // 
            this.drawPanelLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.drawPanelLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawPanelLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.drawPanelLabel.Location = new System.Drawing.Point(0, 0);
            this.drawPanelLabel.Name = "drawPanelLabel";
            this.drawPanelLabel.Size = new System.Drawing.Size(493, 31);
            this.drawPanelLabel.TabIndex = 1;
            this.drawPanelLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numToDrawLabel
            // 
            this.numToDrawLabel.BackColor = System.Drawing.SystemColors.Control;
            this.numToDrawLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numToDrawLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numToDrawLabel.Location = new System.Drawing.Point(0, 0);
            this.numToDrawLabel.Name = "numToDrawLabel";
            this.numToDrawLabel.Size = new System.Drawing.Size(493, 636);
            this.numToDrawLabel.TabIndex = 0;
            this.numToDrawLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.prevGuessLabel);
            this.panel2.Controls.Add(this.buttonPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 638);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 80);
            this.button2.TabIndex = 7;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 80);
            this.button1.TabIndex = 6;
            this.button1.Text = "Load Net";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // prevGuessLabel
            // 
            this.prevGuessLabel.AutoSize = true;
            this.prevGuessLabel.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevGuessLabel.Location = new System.Drawing.Point(8, 421);
            this.prevGuessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prevGuessLabel.Name = "prevGuessLabel";
            this.prevGuessLabel.Size = new System.Drawing.Size(245, 31);
            this.prevGuessLabel.TabIndex = 3;
            this.prevGuessLabel.Text = "Neural Net Guessed: ";
            // 
            // buttonPanel
            // 
            this.buttonPanel.ColumnCount = 2;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.19028F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.80972F));
            this.buttonPanel.Controls.Add(this.submitButton, 0, 0);
            this.buttonPanel.Controls.Add(this.clearButton, 1, 0);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 555);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.RowCount = 1;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.Size = new System.Drawing.Size(494, 83);
            this.buttonPanel.TabIndex = 5;
            // 
            // submitButton
            // 
            this.submitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.Location = new System.Drawing.Point(3, 3);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(236, 77);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Location = new System.Drawing.Point(244, 2);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(248, 79);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear Draw";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 670);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Neural Net";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainContainer.ResumeLayout(false);
            this.numberPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadNetMenuItem;
        private System.Windows.Forms.TableLayoutPanel mainContainer;
        private System.Windows.Forms.Panel numberPanel;
        private System.Windows.Forms.Label numToDrawLabel;
        private System.Windows.Forms.Label drawPanelLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel buttonPanel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label prevGuessLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private GUI.DrawPanel drawPanel;
    }
}

