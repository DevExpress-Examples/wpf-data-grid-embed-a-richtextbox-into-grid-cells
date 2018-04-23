using System.Data;
using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Editors;

namespace GridApplication {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            DataSet dataSet = new DataSet();
            dataSet.ReadXml("Cars2.xml");
            grid.DataSource = dataSet.Tables[0];
        }
    }

    public class RichTextEdit : TextEdit {
        protected override bool NeedsKey(Key key, ModifierKeys modifiers) {
            if (EditMode == EditMode.InplaceActive && key == Key.Enter && 
                (modifiers & ModifierKeys.Control) == 0)
                return true;

            return base.NeedsKey(key, modifiers);
        }
    }
}
