namespace AccountingApp
{
    partial class AccountingApplication
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
            applicationLayout = new Panel();
            plusFunctionsLabel = new Label();
            panelPlusFunctions = new Panel();
            label1 = new Label();
            workerValue = new TextBox();
            labelIntervalUntil = new Label();
            labelIntervalFrom = new Label();
            dateIntervalumUntilValue = new MaskedTextBox();
            dateIntervalumFromValue = new MaskedTextBox();
            workerLabel = new Label();
            timeIntervalLabel = new Label();
            buttonWorker = new Button();
            buttonTasksTimeAmount = new Button();
            workerDataButton = new Button();
            workerTaskValue = new ComboBox();
            workerTimeUntilValue = new MaskedTextBox();
            workerDateValue = new MaskedTextBox();
            workerDate = new Label();
            workerTimeStartValue = new MaskedTextBox();
            workerNameValue = new TextBox();
            workerNameLabel = new Label();
            workerTimeUntilLabel = new Label();
            workerTimeStartLabel = new Label();
            sendingButton = new Button();
            workerCommentValue = new TextBox();
            workerTaskLabel = new Label();
            workerCommentsLabel = new Label();
            labelActivitiesText = new Label();
            saveFileDialog = new SaveFileDialog();
            applicationLayout.SuspendLayout();
            panelPlusFunctions.SuspendLayout();
            SuspendLayout();
            // 
            // applicationLayout
            // 
            applicationLayout.BackColor = Color.FromArgb(135, 187, 162);
            applicationLayout.Controls.Add(plusFunctionsLabel);
            applicationLayout.Controls.Add(panelPlusFunctions);
            applicationLayout.Controls.Add(workerTaskValue);
            applicationLayout.Controls.Add(workerTimeUntilValue);
            applicationLayout.Controls.Add(workerDateValue);
            applicationLayout.Controls.Add(workerDate);
            applicationLayout.Controls.Add(workerTimeStartValue);
            applicationLayout.Controls.Add(workerNameValue);
            applicationLayout.Controls.Add(workerNameLabel);
            applicationLayout.Controls.Add(workerTimeUntilLabel);
            applicationLayout.Controls.Add(workerTimeStartLabel);
            applicationLayout.Controls.Add(sendingButton);
            applicationLayout.Controls.Add(workerCommentValue);
            applicationLayout.Controls.Add(workerTaskLabel);
            applicationLayout.Controls.Add(workerCommentsLabel);
            applicationLayout.Controls.Add(labelActivitiesText);
            applicationLayout.Dock = DockStyle.Fill;
            applicationLayout.Location = new Point(0, 0);
            applicationLayout.Name = "applicationLayout";
            applicationLayout.Size = new Size(1174, 519);
            applicationLayout.TabIndex = 0;
            // 
            // plusFunctionsLabel
            // 
            plusFunctionsLabel.AutoSize = true;
            plusFunctionsLabel.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            plusFunctionsLabel.ForeColor = Color.FromArgb(59, 96, 100);
            plusFunctionsLabel.Location = new Point(671, 16);
            plusFunctionsLabel.Name = "plusFunctionsLabel";
            plusFunctionsLabel.Size = new Size(382, 29);
            plusFunctionsLabel.TabIndex = 20;
            plusFunctionsLabel.Text = "You may also would like to:";
            // 
            // panelPlusFunctions
            // 
            panelPlusFunctions.BackColor = Color.FromArgb(85, 145, 127);
            panelPlusFunctions.Controls.Add(label1);
            panelPlusFunctions.Controls.Add(workerValue);
            panelPlusFunctions.Controls.Add(labelIntervalUntil);
            panelPlusFunctions.Controls.Add(labelIntervalFrom);
            panelPlusFunctions.Controls.Add(dateIntervalumUntilValue);
            panelPlusFunctions.Controls.Add(dateIntervalumFromValue);
            panelPlusFunctions.Controls.Add(workerLabel);
            panelPlusFunctions.Controls.Add(timeIntervalLabel);
            panelPlusFunctions.Controls.Add(buttonWorker);
            panelPlusFunctions.Controls.Add(buttonTasksTimeAmount);
            panelPlusFunctions.Controls.Add(workerDataButton);
            panelPlusFunctions.Location = new Point(569, 47);
            panelPlusFunctions.Margin = new Padding(3, 2, 3, 2);
            panelPlusFunctions.Name = "panelPlusFunctions";
            panelPlusFunctions.Size = new Size(565, 450);
            panelPlusFunctions.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(135, 187, 162);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(59, 96, 100);
            label1.Location = new Point(33, 324);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 26;
            label1.Text = "Worker's name:";
            // 
            // workerValue
            // 
            workerValue.BackColor = Color.FromArgb(201, 228, 202);
            workerValue.BorderStyle = BorderStyle.FixedSingle;
            workerValue.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            workerValue.ForeColor = Color.FromArgb(59, 96, 100);
            workerValue.Location = new Point(281, 326);
            workerValue.Name = "workerValue";
            workerValue.Size = new Size(259, 22);
            workerValue.TabIndex = 21;
            // 
            // labelIntervalUntil
            // 
            labelIntervalUntil.AutoSize = true;
            labelIntervalUntil.BackColor = Color.FromArgb(135, 187, 162);
            labelIntervalUntil.BorderStyle = BorderStyle.FixedSingle;
            labelIntervalUntil.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelIntervalUntil.ForeColor = Color.FromArgb(59, 96, 100);
            labelIntervalUntil.Location = new Point(345, 149);
            labelIntervalUntil.Name = "labelIntervalUntil";
            labelIntervalUntil.Size = new Size(72, 25);
            labelIntervalUntil.TabIndex = 25;
            labelIntervalUntil.Text = "Until:";
            // 
            // labelIntervalFrom
            // 
            labelIntervalFrom.AutoSize = true;
            labelIntervalFrom.BackColor = Color.FromArgb(135, 187, 162);
            labelIntervalFrom.BorderStyle = BorderStyle.FixedSingle;
            labelIntervalFrom.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelIntervalFrom.ForeColor = Color.FromArgb(59, 96, 100);
            labelIntervalFrom.Location = new Point(33, 149);
            labelIntervalFrom.Name = "labelIntervalFrom";
            labelIntervalFrom.Size = new Size(74, 25);
            labelIntervalFrom.TabIndex = 24;
            labelIntervalFrom.Text = "From:";
            // 
            // dateIntervalumUntilValue
            // 
            dateIntervalumUntilValue.BackColor = Color.FromArgb(201, 228, 202);
            dateIntervalumUntilValue.BorderStyle = BorderStyle.FixedSingle;
            dateIntervalumUntilValue.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateIntervalumUntilValue.ForeColor = Color.FromArgb(59, 96, 100);
            dateIntervalumUntilValue.Location = new Point(437, 149);
            dateIntervalumUntilValue.Mask = "00/00/0000";
            dateIntervalumUntilValue.Name = "dateIntervalumUntilValue";
            dateIntervalumUntilValue.Size = new Size(104, 22);
            dateIntervalumUntilValue.TabIndex = 23;
            dateIntervalumUntilValue.ValidatingType = typeof(DateTime);
            // 
            // dateIntervalumFromValue
            // 
            dateIntervalumFromValue.BackColor = Color.FromArgb(201, 228, 202);
            dateIntervalumFromValue.BorderStyle = BorderStyle.FixedSingle;
            dateIntervalumFromValue.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateIntervalumFromValue.ForeColor = Color.FromArgb(59, 96, 100);
            dateIntervalumFromValue.Location = new Point(120, 152);
            dateIntervalumFromValue.Mask = "00/00/0000";
            dateIntervalumFromValue.Name = "dateIntervalumFromValue";
            dateIntervalumFromValue.Size = new Size(104, 22);
            dateIntervalumFromValue.TabIndex = 21;
            dateIntervalumFromValue.ValidatingType = typeof(DateTime);
            // 
            // workerLabel
            // 
            workerLabel.AutoSize = true;
            workerLabel.BackColor = Color.FromArgb(135, 187, 162);
            workerLabel.BorderStyle = BorderStyle.FixedSingle;
            workerLabel.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            workerLabel.ForeColor = Color.FromArgb(59, 96, 100);
            workerLabel.Location = new Point(13, 284);
            workerLabel.Name = "workerLabel";
            workerLabel.Size = new Size(533, 25);
            workerLabel.TabIndex = 22;
            workerLabel.Text = "And if you will give me the name of the worker:";
            // 
            // timeIntervalLabel
            // 
            timeIntervalLabel.AutoSize = true;
            timeIntervalLabel.BackColor = Color.FromArgb(135, 187, 162);
            timeIntervalLabel.BorderStyle = BorderStyle.FixedSingle;
            timeIntervalLabel.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            timeIntervalLabel.ForeColor = Color.FromArgb(59, 96, 100);
            timeIntervalLabel.Location = new Point(-3, 105);
            timeIntervalLabel.Name = "timeIntervalLabel";
            timeIntervalLabel.Size = new Size(568, 25);
            timeIntervalLabel.TabIndex = 21;
            timeIntervalLabel.Text = "Or if you will give me a time interval I can provide:";
            // 
            // buttonWorker
            // 
            buttonWorker.BackColor = Color.FromArgb(201, 228, 202);
            buttonWorker.FlatStyle = FlatStyle.Flat;
            buttonWorker.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonWorker.ForeColor = Color.FromArgb(59, 96, 100);
            buttonWorker.Location = new Point(182, 364);
            buttonWorker.Name = "buttonWorker";
            buttonWorker.Size = new Size(211, 68);
            buttonWorker.TabIndex = 14;
            buttonWorker.Text = "The worker, the work and the amount of time he had spent on it";
            buttonWorker.UseVisualStyleBackColor = false;
            buttonWorker.Click += buttonWorker_Click;
            // 
            // buttonTasksTimeAmount
            // 
            buttonTasksTimeAmount.BackColor = Color.FromArgb(201, 228, 202);
            buttonTasksTimeAmount.FlatStyle = FlatStyle.Flat;
            buttonTasksTimeAmount.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTasksTimeAmount.ForeColor = Color.FromArgb(59, 96, 100);
            buttonTasksTimeAmount.Location = new Point(182, 196);
            buttonTasksTimeAmount.Name = "buttonTasksTimeAmount";
            buttonTasksTimeAmount.Size = new Size(211, 68);
            buttonTasksTimeAmount.TabIndex = 13;
            buttonTasksTimeAmount.Text = "The amount of time which was spent on each task";
            buttonTasksTimeAmount.UseVisualStyleBackColor = false;
            buttonTasksTimeAmount.Click += buttonTasksTimeAmount_Click;
            // 
            // workerDataButton
            // 
            workerDataButton.BackColor = Color.FromArgb(201, 228, 202);
            workerDataButton.FlatStyle = FlatStyle.Flat;
            workerDataButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            workerDataButton.ForeColor = Color.FromArgb(59, 96, 100);
            workerDataButton.Location = new Point(182, 29);
            workerDataButton.Name = "workerDataButton";
            workerDataButton.Size = new Size(211, 55);
            workerDataButton.TabIndex = 12;
            workerDataButton.Text = "See all the activities";
            workerDataButton.UseVisualStyleBackColor = false;
            workerDataButton.Click += usersDataButton_Click;
            // 
            // workerTaskValue
            // 
            workerTaskValue.BackColor = Color.FromArgb(201, 228, 202);
            workerTaskValue.FlatStyle = FlatStyle.System;
            workerTaskValue.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            workerTaskValue.ForeColor = Color.FromArgb(59, 96, 100);
            workerTaskValue.FormattingEnabled = true;
            workerTaskValue.Location = new Point(131, 152);
            workerTaskValue.Margin = new Padding(3, 2, 3, 2);
            workerTaskValue.Name = "workerTaskValue";
            workerTaskValue.Size = new Size(260, 22);
            workerTaskValue.TabIndex = 18;
            // 
            // workerTimeUntilValue
            // 
            workerTimeUntilValue.AsciiOnly = true;
            workerTimeUntilValue.BackColor = Color.FromArgb(201, 228, 202);
            workerTimeUntilValue.BorderStyle = BorderStyle.FixedSingle;
            workerTimeUntilValue.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            workerTimeUntilValue.ForeColor = Color.FromArgb(59, 96, 100);
            workerTimeUntilValue.Location = new Point(212, 400);
            workerTimeUntilValue.Mask = "00:00";
            workerTimeUntilValue.Name = "workerTimeUntilValue";
            workerTimeUntilValue.Size = new Size(51, 22);
            workerTimeUntilValue.TabIndex = 17;
            workerTimeUntilValue.ValidatingType = typeof(DateTime);
            // 
            // workerDateValue
            // 
            workerDateValue.BackColor = Color.FromArgb(201, 228, 202);
            workerDateValue.BorderStyle = BorderStyle.FixedSingle;
            workerDateValue.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            workerDateValue.ForeColor = Color.FromArgb(59, 96, 100);
            workerDateValue.Location = new Point(212, 350);
            workerDateValue.Mask = "00/00/0000";
            workerDateValue.Name = "workerDateValue";
            workerDateValue.Size = new Size(104, 22);
            workerDateValue.TabIndex = 16;
            workerDateValue.ValidatingType = typeof(DateTime);
            // 
            // workerDate
            // 
            workerDate.AutoSize = true;
            workerDate.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            workerDate.ForeColor = Color.FromArgb(59, 96, 100);
            workerDate.Location = new Point(131, 350);
            workerDate.Name = "workerDate";
            workerDate.Size = new Size(69, 23);
            workerDate.TabIndex = 15;
            workerDate.Text = "Date:";
            // 
            // workerTimeStartValue
            // 
            workerTimeStartValue.BackColor = Color.FromArgb(201, 228, 202);
            workerTimeStartValue.BorderStyle = BorderStyle.FixedSingle;
            workerTimeStartValue.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            workerTimeStartValue.ForeColor = Color.FromArgb(59, 96, 100);
            workerTimeStartValue.Location = new Point(353, 371);
            workerTimeStartValue.Mask = "00:00";
            workerTimeStartValue.Name = "workerTimeStartValue";
            workerTimeStartValue.Size = new Size(54, 22);
            workerTimeStartValue.TabIndex = 13;
            workerTimeStartValue.ValidatingType = typeof(DateTime);
            // 
            // workerNameValue
            // 
            workerNameValue.BackColor = Color.FromArgb(201, 228, 202);
            workerNameValue.BorderStyle = BorderStyle.FixedSingle;
            workerNameValue.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            workerNameValue.ForeColor = Color.FromArgb(59, 96, 100);
            workerNameValue.Location = new Point(131, 86);
            workerNameValue.Name = "workerNameValue";
            workerNameValue.Size = new Size(259, 22);
            workerNameValue.TabIndex = 11;
            // 
            // workerNameLabel
            // 
            workerNameLabel.AutoSize = true;
            workerNameLabel.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            workerNameLabel.ForeColor = Color.FromArgb(59, 96, 100);
            workerNameLabel.Location = new Point(131, 62);
            workerNameLabel.Name = "workerNameLabel";
            workerNameLabel.Size = new Size(226, 23);
            workerNameLabel.TabIndex = 10;
            workerNameLabel.Text = "What is your name?";
            // 
            // workerTimeUntilLabel
            // 
            workerTimeUntilLabel.AutoSize = true;
            workerTimeUntilLabel.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            workerTimeUntilLabel.ForeColor = Color.FromArgb(59, 96, 100);
            workerTimeUntilLabel.Location = new Point(131, 398);
            workerTimeUntilLabel.Name = "workerTimeUntilLabel";
            workerTimeUntilLabel.Size = new Size(70, 23);
            workerTimeUntilLabel.TabIndex = 8;
            workerTimeUntilLabel.Text = "Until:";
            // 
            // workerTimeStartLabel
            // 
            workerTimeStartLabel.AutoSize = true;
            workerTimeStartLabel.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            workerTimeStartLabel.ForeColor = Color.FromArgb(59, 96, 100);
            workerTimeStartLabel.Location = new Point(131, 371);
            workerTimeStartLabel.Name = "workerTimeStartLabel";
            workerTimeStartLabel.Size = new Size(214, 23);
            workerTimeStartLabel.TabIndex = 6;
            workerTimeStartLabel.Text = "From (exact time):";
            // 
            // sendingButton
            // 
            sendingButton.BackColor = Color.FromArgb(201, 228, 202);
            sendingButton.FlatStyle = FlatStyle.Flat;
            sendingButton.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            sendingButton.ForeColor = Color.FromArgb(59, 96, 100);
            sendingButton.Location = new Point(158, 442);
            sendingButton.Name = "sendingButton";
            sendingButton.Size = new Size(180, 55);
            sendingButton.TabIndex = 5;
            sendingButton.Text = "Send";
            sendingButton.UseVisualStyleBackColor = false;
            sendingButton.Click += sendingButton_Click;
            // 
            // workerCommentValue
            // 
            workerCommentValue.BackColor = Color.FromArgb(201, 228, 202);
            workerCommentValue.BorderStyle = BorderStyle.FixedSingle;
            workerCommentValue.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            workerCommentValue.ForeColor = Color.FromArgb(59, 96, 100);
            workerCommentValue.Location = new Point(131, 217);
            workerCommentValue.Multiline = true;
            workerCommentValue.Name = "workerCommentValue";
            workerCommentValue.Size = new Size(259, 108);
            workerCommentValue.TabIndex = 4;
            // 
            // workerTaskLabel
            // 
            workerTaskLabel.AutoSize = true;
            workerTaskLabel.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            workerTaskLabel.ForeColor = Color.FromArgb(59, 96, 100);
            workerTaskLabel.Location = new Point(96, 128);
            workerTaskLabel.Name = "workerTaskLabel";
            workerTaskLabel.Size = new Size(311, 23);
            workerTaskLabel.TabIndex = 2;
            workerTaskLabel.Text = "What have you been doing?";
            // 
            // workerCommentsLabel
            // 
            workerCommentsLabel.AutoSize = true;
            workerCommentsLabel.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            workerCommentsLabel.ForeColor = Color.FromArgb(59, 96, 100);
            workerCommentsLabel.Location = new Point(35, 192);
            workerCommentsLabel.Name = "workerCommentsLabel";
            workerCommentsLabel.Size = new Size(433, 23);
            workerCommentsLabel.TabIndex = 1;
            workerCommentsLabel.Text = "Any comments on the work performed:";
            // 
            // labelActivitiesText
            // 
            labelActivitiesText.AutoSize = true;
            labelActivitiesText.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelActivitiesText.ForeColor = Color.FromArgb(59, 96, 100);
            labelActivitiesText.Location = new Point(24, 16);
            labelActivitiesText.Name = "labelActivitiesText";
            labelActivitiesText.Size = new Size(471, 29);
            labelActivitiesText.TabIndex = 0;
            labelActivitiesText.Text = "Lets take a note of your activities:";
            // 
            // AccountingApplication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 519);
            Controls.Add(applicationLayout);
            Name = "AccountingApplication";
            Text = "Working Time Accountant Application";
            applicationLayout.ResumeLayout(false);
            applicationLayout.PerformLayout();
            panelPlusFunctions.ResumeLayout(false);
            panelPlusFunctions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel applicationLayout;
        private Label labelActivitiesText;
        private Button sendingButton;
        private TextBox workerCommentValue;
        private Label workerTaskLabel;
        private Label workerCommentsLabel;
        private Label workerTimeStartLabel;
        private Label workerTimeUntilLabel;
        private Label workerNameLabel;
        private TextBox workerNameValue;
        private Button workerDataButton;
        private MaskedTextBox workerTimeStartValue;
        private Label workerDate;
        private MaskedTextBox workerDateValue;
        private MaskedTextBox workerTimeUntilValue;
        private ComboBox workerTaskValue;
        private Panel panelPlusFunctions;
        private Label plusFunctionsLabel;
        private Button buttonTasksTimeAmount;
        private Button buttonWorker;
        private Label workerLabel;
        private Label timeIntervalLabel;
        private Label labelIntervalFrom;
        private MaskedTextBox dateIntervalumUntilValue;
        private MaskedTextBox dateIntervalumFromValue;
        private TextBox workerValue;
        private Label labelIntervalUntil;
        private Label label1;
        private SaveFileDialog saveFileDialog;
    }
}