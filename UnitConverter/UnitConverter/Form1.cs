namespace UnitConverter
{
    public partial class Form1 : Form
    {   private ConverterService _converterService;
        public Form1()
        {   
            InitializeComponent();
            _converterService = new ConverterService();
            cboType.DataSource = Enum.GetValues(typeof(TypeEnum));
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            lstFrom.DataSource = Enum.GetValues(typeof(MassEnum));
            lstTo.DataSource = Enum.GetValues(typeof(MassEnum));

        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAmount.Text = String.Empty;
            txtConvertedAmount.Text = String.Empty;
            var type = (TypeEnum)cboType.SelectedItem;

            switch (type)
            {
                case TypeEnum.Mass:
                    lstFrom.DataSource = Enum.GetValues(typeof(MassEnum));
                    lstTo.DataSource = Enum.GetValues(typeof(MassEnum));
                    break;
                case TypeEnum.Temperature:
                    lstFrom.DataSource = Enum.GetValues(typeof(TemperatureEnum));
                    lstTo.DataSource = Enum.GetValues(typeof(TemperatureEnum));
                    break;
                case TypeEnum.Time:
                    lstFrom.DataSource = Enum.GetValues(typeof(TimeEnum));
                    lstTo.DataSource = Enum.GetValues(typeof(TimeEnum));
                    break;
                default:
                    break;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(txtAmount.Text.Length<=0)
                return;
            if (lstFrom.SelectedItems == lstTo.SelectedItems)
            {
                txtConvertedAmount.Text = txtAmount.Text;
            }
            var type = (TypeEnum)cboType.SelectedItem;
            if (!double.TryParse(txtAmount.Text, out double number))
            {
                MessageBox.Show("El valor ingresado debe ser un numero");
                return;
            }
            double amount = double.Parse(txtAmount.Text);
            double convertedAmount = 0;

            switch (type)
            {
                case TypeEnum.Mass:
                    var massFrom = (MassEnum)lstFrom.SelectedItem;
                    var massTo = (MassEnum)lstTo.SelectedItem;

                    convertedAmount = _converterService.ConvertMassUnit(massFrom, massTo, amount);
                    break;
                case TypeEnum.Temperature:
                    var tempFrom = (TemperatureEnum)lstFrom.SelectedItem;
                    var tempTo = (TemperatureEnum)lstTo.SelectedItem;

                    convertedAmount = _converterService.ConvertTemperatureUnit(tempFrom, tempTo, amount);
                    break;
                case TypeEnum.Time:
                    var timeFrom = (TimeEnum)lstFrom.SelectedItem;
                    var timeTo = (TimeEnum)lstTo.SelectedItem;

                    convertedAmount = _converterService.ConvertTimeUnit(timeFrom, timeTo, amount);
                    break;
            }
            txtConvertedAmount.Text = convertedAmount.ToString();
        }
    }
}