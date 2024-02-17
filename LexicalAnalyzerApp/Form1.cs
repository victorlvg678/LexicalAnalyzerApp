using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using LexicalAnalyzerApp.Classes;
using System.Collections.Generic;

namespace LexicalAnalyzerApp
{
    public partial class Form1 : Form
    {
        private Dictionary<int, string> _symbolTable;

        public Form1()
        {
            InitializeComponent();
            _symbolTable = new Dictionary<int, string>();
            _symbolTable.Add(0, "Identificador");
            _symbolTable.Add(1, "Entero");
            _symbolTable.Add(2, "Real");
            _symbolTable.Add(3, "Cadena");
            _symbolTable.Add(4, "Tipo");
            _symbolTable.Add(5, "Operador Suma");
            _symbolTable.Add(6, "Operador Multiplicacion");
            _symbolTable.Add(7, "Operador Relacional");
            _symbolTable.Add(8, "Operador OR");
            _symbolTable.Add(9, "Operador AND");
            _symbolTable.Add(10, "Operador NOT");
            _symbolTable.Add(11, "Operador Igualdad");
            _symbolTable.Add(12, "Punto y coma");
            _symbolTable.Add(13, "Coma");
            _symbolTable.Add(14, "Parentesis Izquierdo");
            _symbolTable.Add(15, "Parentesis Derecho");
            _symbolTable.Add(16, "Corchete Izquierdo");
            _symbolTable.Add(17, "Corchete Derecho");
            _symbolTable.Add(18, "Igual");
            _symbolTable.Add(19, "if");
            _symbolTable.Add(20, "while");
            _symbolTable.Add(21, "return");
            _symbolTable.Add(22, "else");
            _symbolTable.Add(23, "$");
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "*.txt|";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CodeTextBox.Text = Encoding.UTF8.GetString(File.ReadAllBytes(openFileDialog.FileName));
            }
            else
            {
                MessageBox.Show("No se pudo abrir el archivo. Algo ocurrió al intentar abrir el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LexicalAnalyzerButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (string.IsNullOrWhiteSpace(CodeTextBox.Text))
            {
                MessageBox.Show("No se puede analizar lexicamente. La caja de texto de código está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var elements = CodeTextBox.Text.Split(new string[] { "\r\n", "\r", "\n", " "}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var element in elements)
            {
                var lexicalAnalyzer = new LexicalAnalyzer(element, 0, 0);

                for (int i = 0; i < element.Length; i++)
                {
                    lexicalAnalyzer.getNextState();
                }

                var tokenId = lexicalAnalyzer.getTokenNumber();

                if (tokenId < 0 || !_symbolTable.ContainsKey(tokenId))
                    continue;

                dataGridView1.Rows.Add(element, _symbolTable[tokenId], tokenId);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
