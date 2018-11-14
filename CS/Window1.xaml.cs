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
            grid.ItemsSource = dataSet.Tables[0];
        }

        private void view_GetActiveEditorNeedsKey(object sender, DevExpress.Xpf.Grid.GetActiveEditorNeedsKeyEventArgs e) {
            if(e.Column.FieldName == "RtfContent") {
                if(e.Key == Key.Enter && !e.Modifiers.HasFlag(ModifierKeys.Control))
                    e.NeedsKey = true;
            }
        }

        private void view_ProcessEditorActivationAction(object sender, DevExpress.Xpf.Grid.ProcessEditorActivationActionEventArgs e) {
            if(e.Column.FieldName == "RtfContent") {
                if(e.ActivationAction == ActivationAction.MouseLeftButtonDown)
                    e.RaiseEventAgain = true;
            }
        }
    }
}
