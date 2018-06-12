﻿namespace ApiGrafos
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
            this.grafoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoGrafoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVerticeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarAdjacenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adacenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVer = new System.Windows.Forms.Button();
            this.nameVert = new System.Windows.Forms.TextBox();
            this.newAdj = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameGrafo = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nameVer1 = new System.Windows.Forms.TextBox();
            this.nameVer2 = new System.Windows.Forms.TextBox();
            this.nameVer3 = new System.Windows.Forms.TextBox();
            this.nameVert4 = new System.Windows.Forms.TextBox();
            this.nameVer5 = new System.Windows.Forms.TextBox();
            this.nameVer6 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafoToolStripMenuItem,
            this.verticeToolStripMenuItem,
            this.adacenciaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1090, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // grafoToolStripMenuItem
            // 
            this.grafoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoGrafoToolStripMenuItem});
            this.grafoToolStripMenuItem.Name = "grafoToolStripMenuItem";
            this.grafoToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.grafoToolStripMenuItem.Text = "Grafo";
            this.grafoToolStripMenuItem.Click += new System.EventHandler(this.grafoToolStripMenuItem_Click);
            // 
            // novoGrafoToolStripMenuItem
            // 
            this.novoGrafoToolStripMenuItem.Name = "novoGrafoToolStripMenuItem";
            this.novoGrafoToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.novoGrafoToolStripMenuItem.Text = "NovoGrafo";
            // 
            // verticeToolStripMenuItem
            // 
            this.verticeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVerticeToolStripMenuItem,
            this.verificarAdjacenciaToolStripMenuItem});
            this.verticeToolStripMenuItem.Name = "verticeToolStripMenuItem";
            this.verticeToolStripMenuItem.Size = new System.Drawing.Size(74, 25);
            this.verticeToolStripMenuItem.Text = "Vertice";
            // 
            // addVerticeToolStripMenuItem
            // 
            this.addVerticeToolStripMenuItem.Name = "addVerticeToolStripMenuItem";
            this.addVerticeToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.addVerticeToolStripMenuItem.Text = "AddVertice";
            // 
            // verificarAdjacenciaToolStripMenuItem
            // 
            this.verificarAdjacenciaToolStripMenuItem.Name = "verificarAdjacenciaToolStripMenuItem";
            this.verificarAdjacenciaToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.verificarAdjacenciaToolStripMenuItem.Text = "Verificar Adjacencia";
            // 
            // adacenciaToolStripMenuItem
            // 
            this.adacenciaToolStripMenuItem.Name = "adacenciaToolStripMenuItem";
            this.adacenciaToolStripMenuItem.Size = new System.Drawing.Size(103, 25);
            this.adacenciaToolStripMenuItem.Text = "Adjacencia";
            // 
            // newVer
            // 
            this.newVer.Enabled = false;
            this.newVer.Location = new System.Drawing.Point(18, 103);
            this.newVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newVer.Name = "newVer";
            this.newVer.Size = new System.Drawing.Size(160, 35);
            this.newVer.TabIndex = 4;
            this.newVer.Text = "Adicionar vertice";
            this.newVer.UseVisualStyleBackColor = true;
            this.newVer.Click += new System.EventHandler(this.NewVer_Click);
            // 
            // nameVert
            // 
            this.nameVert.Enabled = false;
            this.nameVert.Location = new System.Drawing.Point(186, 106);
            this.nameVert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameVert.Name = "nameVert";
            this.nameVert.Size = new System.Drawing.Size(97, 26);
            this.nameVert.TabIndex = 5;
            // 
            // newAdj
            // 
            this.newAdj.Location = new System.Drawing.Point(963, 103);
            this.newAdj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newAdj.Name = "newAdj";
            this.newAdj.Size = new System.Drawing.Size(111, 31);
            this.newAdj.TabIndex = 6;
            this.newAdj.Text = "Adjacência ";
            this.newAdj.UseVisualStyleBackColor = true;
            this.newAdj.Click += new System.EventHandler(this.newAdj_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 389);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Criar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "NomeGrafo:";
            // 
            // nameGrafo
            // 
            this.nameGrafo.Location = new System.Drawing.Point(108, 5);
            this.nameGrafo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameGrafo.Name = "nameGrafo";
            this.nameGrafo.Size = new System.Drawing.Size(246, 26);
            this.nameGrafo.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.nameGrafo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 42);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(384, 40);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // nameVer1
            // 
            this.nameVer1.Enabled = false;
            this.nameVer1.Location = new System.Drawing.Point(294, 106);
            this.nameVer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameVer1.Name = "nameVer1";
            this.nameVer1.Size = new System.Drawing.Size(97, 26);
            this.nameVer1.TabIndex = 11;
            this.nameVer1.Visible = false;
            // 
            // nameVer2
            // 
            this.nameVer2.Enabled = false;
            this.nameVer2.Location = new System.Drawing.Point(402, 106);
            this.nameVer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameVer2.Name = "nameVer2";
            this.nameVer2.Size = new System.Drawing.Size(97, 26);
            this.nameVer2.TabIndex = 12;
            this.nameVer2.Visible = false;
            // 
            // nameVer3
            // 
            this.nameVer3.Enabled = false;
            this.nameVer3.Location = new System.Drawing.Point(510, 106);
            this.nameVer3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameVer3.Name = "nameVer3";
            this.nameVer3.Size = new System.Drawing.Size(97, 26);
            this.nameVer3.TabIndex = 13;
            this.nameVer3.Visible = false;
            // 
            // nameVert4
            // 
            this.nameVert4.Enabled = false;
            this.nameVert4.Location = new System.Drawing.Point(618, 106);
            this.nameVert4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameVert4.Name = "nameVert4";
            this.nameVert4.Size = new System.Drawing.Size(97, 26);
            this.nameVert4.TabIndex = 14;
            this.nameVert4.Visible = false;
            // 
            // nameVer5
            // 
            this.nameVer5.Enabled = false;
            this.nameVer5.Location = new System.Drawing.Point(726, 106);
            this.nameVer5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameVer5.Name = "nameVer5";
            this.nameVer5.Size = new System.Drawing.Size(97, 26);
            this.nameVer5.TabIndex = 15;
            this.nameVer5.Visible = false;
            // 
            // nameVer6
            // 
            this.nameVer6.Enabled = false;
            this.nameVer6.Location = new System.Drawing.Point(834, 106);
            this.nameVer6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameVer6.Name = "nameVer6";
            this.nameVer6.Size = new System.Drawing.Size(97, 26);
            this.nameVer6.TabIndex = 16;
            this.nameVer6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 443);
            this.Controls.Add(this.nameVer6);
            this.Controls.Add(this.nameVer5);
            this.Controls.Add(this.nameVert4);
            this.Controls.Add(this.nameVer3);
            this.Controls.Add(this.nameVer2);
            this.Controls.Add(this.nameVer1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.newAdj);
            this.Controls.Add(this.nameVert);
            this.Controls.Add(this.newVer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Grafo1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem grafoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adacenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoGrafoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVerticeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarAdjacenciaToolStripMenuItem;
        private System.Windows.Forms.Button newVer;
        private System.Windows.Forms.TextBox nameVert;
        private System.Windows.Forms.Button newAdj;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameGrafo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox nameVer1;
        private System.Windows.Forms.TextBox nameVer2;
        private System.Windows.Forms.TextBox nameVer3;
        private System.Windows.Forms.TextBox nameVert4;
        private System.Windows.Forms.TextBox nameVer5;
        private System.Windows.Forms.TextBox nameVer6;
    }
}

