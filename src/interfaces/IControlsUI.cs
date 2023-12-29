
namespace SQLProgram
{
    interface IControlsUI
    {
        public static RichTextBox RichTextBox { get; set; }
        public static ComboBox ComboBox { get; set; }
        public static Label LabelDataBaseList { get; set; }
        public static Label LabelSchemasCurrentDb { get; set; }
        public static DataGridView DataGridView { get; set; }
        public static Button ButtonExecuteSqlCode { get; set; }

        public const int SHIFT = 35;
        public void CreateControls(ref Form form);
    }
}
