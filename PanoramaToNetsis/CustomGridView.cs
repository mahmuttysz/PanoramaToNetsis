using DevExpress.XtraGrid.Views.Grid;

namespace PanoramaToNetsis
{
    public class CustomGridView : GridView
    {
        protected override bool AllowFixedCheckboxSelectorColumn
        {
            get
            {
                return true;
            }
        }

        protected override void CreateCheckboxSelectorColumn()
        {
            base.CreateCheckboxSelectorColumn();
            CheckboxSelectorColumn.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
        }
    }
}