using System.Drawing.Text;
using System.Reflection.Metadata.Ecma335;
using org.mariuszgromada.math.mxparser;
using org.mariuszgromada.math.mxparser.mathcollection;

namespace ProyectoProfeBendicion
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        //Events
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEval_MouseClick(object sender, MouseEventArgs e)
        {
            bool evaluate = true;
            lblError.Text = "";
            if (!IsAValidExpression(txtFunction.Text)) evaluate = false;
            if (!IsDomainNatural(txtDomain.Text)) evaluate = false;
            if (!IsDomainNatural(txtEndDomain.Text)) evaluate = false;
            if (evaluate)
            {
                CalculateExpression(txtFunction.Text, txtDomain.Text, txtEndDomain.Text);
            }

        }
        #region Formulas
        //Sucesiones num�ricas

        //Descomponer la expresi�n
        private bool IsAValidExpression(string expression)
        {
            Expression function = new Expression(expression);
            bool isValid = true;
            if (function.checkSyntax())
            {
                lblError.Text += "La sint�xis de la expresi�n no es v�lida\n";
                isValid = false;
            }
            if (function.getMissingUserDefinedArguments().Length > 1)
            {
                lblError.Text += "Hay m�s de una variable declarada, aseg�rese de que s�lo exista una variable\n";
                isValid = false;
            }
            return isValid;
        }
        private bool IsDomainNatural(string expression)
        {
            bool isValid = true;
            if (!int.TryParse(expression, out _))
            {
                lblError.Text += "El valor del dominio debe ser un n�mero real\n";
                isValid = false;
            }
            return isValid;
        }

        // Extraemos los argumentos de la funci�n para definirlos despu�s
        private void CalculateExpression(string expression, string domain, string domainend)
        {
            Expression function = new Expression(expression);
            string[] missingArgs = function.getMissingUserDefinedArguments();
            lstRange.Items.Clear();
            for (int i = 0; i < missingArgs.Length; i++)
            {
                function.addArguments(new Argument(missingArgs[i]));
            }
            for (int j = int.Parse(domain); j <= int.Parse(domainend); j++)
            {
                function.setArgumentValue(missingArgs[0], j);
                lstRange.Items.Add(string.Concat(missingArgs[0],
                    " = ",
                    j,
                    "; ",
                    function.getExpressionString(),
                    " = ",
                    function.calculate()));
            }
        }
        #endregion
    }
}