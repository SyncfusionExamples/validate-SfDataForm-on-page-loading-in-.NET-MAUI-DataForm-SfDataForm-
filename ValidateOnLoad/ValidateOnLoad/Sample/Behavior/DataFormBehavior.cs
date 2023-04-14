using Syncfusion.Maui.DataForm;

namespace ValidateOnLoad
{
    public class DataFormBehavior : Behavior<ContentPage>
    {
        private SfDataForm dataForm;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            this.dataForm = bindable.FindByName<SfDataForm>("dataForm");
            if (this.dataForm != null)
            {   
                this.dataForm.ItemsSourceProvider = new ItemSourceProvider();
                this.dataForm.RegisterEditor("Country", DataFormEditorType.AutoComplete);
                this.dataForm.RegisterEditor("City", DataFormEditorType.ComboBox);
                this.dataForm.Loaded += OnLoaded;
            }
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            this.dataForm.Validate();
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            this.dataForm = bindable.FindByName<SfDataForm>("dataForm");
            if (this.dataForm != null)
            {
                this.dataForm.Loaded -= OnLoaded;
            }

            this.dataForm = null;
        }
    }
}