namespace DataPresentation
{
	partial class DataPresentation
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
            this.components = new System.ComponentModel.Container();
            this.bStartPumping = new System.Windows.Forms.Button();
            this.dgSensorValueList = new System.Windows.Forms.DataGridView();
            this.sensorValueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbPacientCodeStart = new System.Windows.Forms.ComboBox();
            this.bStopPumping = new System.Windows.Forms.Button();
            this.tbTimePeriod = new System.Windows.Forms.TextBox();
            this.PacientCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgSensorValueList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorValueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bStartPumping
            // 
            this.bStartPumping.Location = new System.Drawing.Point(799, 228);
            this.bStartPumping.Margin = new System.Windows.Forms.Padding(4);
            this.bStartPumping.Name = "bStartPumping";
            this.bStartPumping.Size = new System.Drawing.Size(100, 28);
            this.bStartPumping.TabIndex = 0;
            this.bStartPumping.Text = "Start";
            this.bStartPumping.UseVisualStyleBackColor = true;
            this.bStartPumping.Click += new System.EventHandler(this.bStartPumping_Click);
            // 
            // dgSensorValueList
            // 
            this.dgSensorValueList.AllowUserToOrderColumns = true;
            this.dgSensorValueList.AllowUserToResizeRows = false;
            this.dgSensorValueList.AutoGenerateColumns = false;
            this.dgSensorValueList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSensorValueList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSensorValueList.CausesValidation = false;
            this.dgSensorValueList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgSensorValueList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSensorValueList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PacientCode,
            this.typeDataGridViewTextBoxColumn,
            this.timeStampStringDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dgSensorValueList.DataSource = this.sensorValueBindingSource;
            this.dgSensorValueList.Location = new System.Drawing.Point(29, 71);
            this.dgSensorValueList.Name = "dgSensorValueList";
            this.dgSensorValueList.ReadOnly = true;
            this.dgSensorValueList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgSensorValueList.RowHeadersVisible = false;
            this.dgSensorValueList.RowHeadersWidth = 20;
            this.dgSensorValueList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgSensorValueList.RowTemplate.Height = 60;
            this.dgSensorValueList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgSensorValueList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgSensorValueList.Size = new System.Drawing.Size(739, 426);
            this.dgSensorValueList.StandardTab = true;
            this.dgSensorValueList.TabIndex = 1;
            this.dgSensorValueList.UseWaitCursor = true;
            this.dgSensorValueList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSensorValueList_CellContentClick);
            // 
            // sensorValueBindingSource
            // 
            this.sensorValueBindingSource.DataSource = typeof(Sensor.SensorValue);
            this.sensorValueBindingSource.CurrentChanged += new System.EventHandler(this.sensorValueBindingSource_CurrentChanged);
            // 
            // cbPacientCodeStart
            // 
            this.cbPacientCodeStart.DataSource = this.sensorValueBindingSource;
            this.cbPacientCodeStart.FormattingEnabled = true;
            this.cbPacientCodeStart.Location = new System.Drawing.Point(799, 113);
            this.cbPacientCodeStart.Name = "cbPacientCodeStart";
            this.cbPacientCodeStart.Size = new System.Drawing.Size(217, 24);
            this.cbPacientCodeStart.TabIndex = 2;
            // 
            // bStopPumping
            // 
            this.bStopPumping.Location = new System.Drawing.Point(916, 228);
            this.bStopPumping.Margin = new System.Windows.Forms.Padding(4);
            this.bStopPumping.Name = "bStopPumping";
            this.bStopPumping.Size = new System.Drawing.Size(100, 28);
            this.bStopPumping.TabIndex = 3;
            this.bStopPumping.Text = "Stop";
            this.bStopPumping.UseVisualStyleBackColor = true;
            this.bStopPumping.Click += new System.EventHandler(this.bStopPumping_Click);
            // 
            // tbTimePeriod
            // 
            this.tbTimePeriod.Location = new System.Drawing.Point(799, 173);
            this.tbTimePeriod.Name = "tbTimePeriod";
            this.tbTimePeriod.Size = new System.Drawing.Size(217, 22);
            this.tbTimePeriod.TabIndex = 4;
            this.tbTimePeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PacientCode
            // 
            this.PacientCode.DataPropertyName = "PacientCode";
            this.PacientCode.HeaderText = "Pacient";
            this.PacientCode.MinimumWidth = 6;
            this.PacientCode.Name = "PacientCode";
            this.PacientCode.ReadOnly = true;
            this.PacientCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.FillWeight = 50F;
            this.typeDataGridViewTextBoxColumn.HeaderText = "Sensor";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeStampStringDataGridViewTextBoxColumn
            // 
            this.timeStampStringDataGridViewTextBoxColumn.DataPropertyName = "TimeStampString";
            this.timeStampStringDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
            this.timeStampStringDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeStampStringDataGridViewTextBoxColumn.Name = "timeStampStringDataGridViewTextBoxColumn";
            this.timeStampStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(799, 290);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // DataPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 702);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.tbTimePeriod);
            this.Controls.Add(this.bStopPumping);
            this.Controls.Add(this.cbPacientCodeStart);
            this.Controls.Add(this.dgSensorValueList);
            this.Controls.Add(this.bStartPumping);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataPresentation";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSensorValueList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorValueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bStartPumping;
		private System.Windows.Forms.DataGridView dgSensorValueList;
		private System.Windows.Forms.BindingSource sensorValueBindingSource;
        private System.Windows.Forms.ComboBox cbPacientCodeStart;
        private System.Windows.Forms.Button bStopPumping;
        private System.Windows.Forms.TextBox tbTimePeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacientCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

