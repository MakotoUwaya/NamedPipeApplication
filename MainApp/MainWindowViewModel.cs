using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MainApp.Gnavi;
using MainApp.Master;
using Prism.Commands;
using Prism.Mvvm;

namespace MainApp
{
    public class MainWindowViewModel : BindableBase
    {
        public string WindowTitle => "GURUNAVI WEB SERVICE Client";

        private IEnumerable<Area> areas;
        public IEnumerable<Area> Areas
        {
            get { return this.areas; }
            set
            {
                this.areas = value;
                this.RaisePropertyChanged(nameof(this.Areas));
            }
        }

        private string selectedArea;
        public string SelectedArea
        {
            get { return this.selectedArea; }
            set
            {
                this.selectedArea = value;
                this.RaisePropertyChanged(nameof(this.SelectedArea));
                this.RaisePropertyChanged(nameof(this.Prefs));
                this.RaisePropertyChanged(nameof(this.AreaLs));
                this.RaisePropertyChanged(nameof(this.AreaMs));
                this.RaisePropertyChanged(nameof(this.AreaSs));
            }
        }

        private IEnumerable<Pref> prefs;
        public IEnumerable<Pref> Prefs
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(this.SelectedArea))
                {
                    return this.prefs.Where(a => a.AreaCode == this.SelectedArea);
                }
                return this.prefs;
            }
            set
            {
                this.prefs = value;
                this.RaisePropertyChanged(nameof(this.Prefs));
            }
        }

        private string selectedPref;
        public string SelectedPref
        {
            get { return this.selectedPref; }
            set
            {
                this.selectedPref = value;
                this.RaisePropertyChanged(nameof(this.SelectedPref));
                this.RaisePropertyChanged(nameof(this.AreaLs));
                this.RaisePropertyChanged(nameof(this.AreaMs));
                this.RaisePropertyChanged(nameof(this.AreaSs));
            }
        }

        private IEnumerable<AreaL> areaLs;
        public IEnumerable<AreaL> AreaLs
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(this.SelectedPref))
                {
                    return this.areaLs.Where(a => a.Pref.Code == this.SelectedPref);
                }

                if (!string.IsNullOrWhiteSpace(this.SelectedArea))
                {
                    return this.areaLs.Where(a => ((IList<string>)this.Prefs).Contains(a.Pref.Code));
                }

                return this.areaLs;
            }
            set
            {
                this.areaLs = value;
                this.RaisePropertyChanged(nameof(this.AreaLs));
            }
        }

        private string selectedAreaL;
        public string SelectedAreaL
        {
            get { return this.selectedAreaL; }
            set
            {
                this.selectedAreaL = value;
                this.RaisePropertyChanged(nameof(this.SelectedAreaL));
                this.RaisePropertyChanged(nameof(this.AreaMs));
                this.RaisePropertyChanged(nameof(this.AreaSs));
            }
        }

        private IEnumerable<AreaM> areaMs;
        public IEnumerable<AreaM> AreaMs
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(this.SelectedAreaL))
                {
                    return this.areaMs.Where(a => a.AreaL.Code == this.SelectedAreaL);
                }

                if (!string.IsNullOrWhiteSpace(this.SelectedPref))
                {
                    return this.areaMs.Where(a => a.Pref.Code == this.SelectedPref);
                }

                if (!string.IsNullOrWhiteSpace(this.SelectedArea))
                {
                    return this.areaMs.Where(a => ((IList<string>)this.Prefs).Contains(a.Pref.Code));
                }
                return this.areaMs;
            }
            set
            {
                this.areaMs = value;
                this.RaisePropertyChanged(nameof(this.AreaMs));
            }
        }

        private string selectedAreaM;
        public string SelectedAreaM
        {
            get { return this.selectedAreaM; }
            set
            {
                this.selectedAreaM = value;
                this.RaisePropertyChanged(nameof(this.SelectedAreaM));
                this.RaisePropertyChanged(nameof(this.AreaSs));
            }
        }

        private IEnumerable<AreaS> areaSs;
        public IEnumerable<AreaS> AreaSs
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(this.SelectedAreaM))
                {
                    return this.areaSs.Where(a => a.AreaM.Code == this.SelectedAreaM);
                }

                if (!string.IsNullOrWhiteSpace(this.SelectedAreaL))
                {
                    return this.areaSs.Where(a => a.AreaL.Code == this.SelectedAreaL);
                }

                if (!string.IsNullOrWhiteSpace(this.SelectedPref))
                {
                    return this.areaSs.Where(a => a.Pref.Code == this.SelectedPref);
                }
                if (!string.IsNullOrWhiteSpace(this.SelectedArea))
                {
                    return this.areaSs.Where(a => ((IList<string>)this.Prefs).Contains(a.Pref.Code));
                }

                return this.areaSs;
            }
            set
            {
                this.areaSs = value;
                this.RaisePropertyChanged(nameof(this.AreaSs));
            }
        }

        private string selectedAreaS;
        public string SelectedAreaS
        {
            get { return this.selectedAreaS; }
            set
            {
                this.selectedAreaS = value;
                this.RaisePropertyChanged(nameof(this.SelectedAreaS));
            }
        }

        private IEnumerable<CategoryL> categoryLs;
        public IEnumerable<CategoryL> CategoryLs
        {
            get { return this.categoryLs; }
            set
            {
                this.categoryLs = value;
                this.RaisePropertyChanged(nameof(this.CategoryLs));
            }
        }

        private string selectedCategoryL;
        public string SelectedCategoryL
        {
            get { return this.selectedCategoryL; }
            set
            {
                this.selectedCategoryL = value;
                this.RaisePropertyChanged(nameof(this.SelectedCategoryL));
                this.RaisePropertyChanged(nameof(this.CategorySs));
            }
        }

        private IEnumerable<CategoryS> categorySs;
        public IEnumerable<CategoryS> CategorySs
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(this.SelectedCategoryL))
                {
                    return this.categorySs.Where(a => a.CategoryLCode == this.SelectedCategoryL);
                }

                return this.categorySs;
            }
            set
            {
                this.categorySs = value;
                this.RaisePropertyChanged(nameof(this.CategorySs));
            }
        }

        private string selectedCategoryS;
        public string SelectedCategoryS
        {
            get { return this.selectedCategoryS; }
            set
            {
                this.selectedCategoryS = value;
                this.RaisePropertyChanged(nameof(this.SelectedCategoryS));
            }
        }

        private IEnumerable<Rest> rests;
        public IEnumerable<Rest> Rests
        {
            get
            {
                return this.rests;
            }
            set
            {
                this.rests = value;
                this.RaisePropertyChanged(nameof(this.Rests));
            }
        }

        public DelegateCommand ResetAreaCommand { get; set; }

        public DelegateCommand SearchCommand { get; set; }

        public MainWindowViewModel()
        {
            var reader = new HttpDataReader();

            var areas = new AreaCollection(reader);
            Task.Run(async () => await areas.Load())
                .ContinueWith(_ => this.Areas = areas.List);

            var prefs = new Prefs(reader);
            Task.Run(async () => await prefs.Load())
                .ContinueWith(_ => this.Prefs = prefs.List);

            var areaL = new AreaLs(reader);
            Task.Run(async () => await areaL.Load())
                .ContinueWith(_ => this.AreaLs = areaL.List);

            var areaM = new AreaMs(reader);
            Task.Run(async () => await areaM.Load())
                .ContinueWith(_ => this.AreaMs = areaM.List);

            var areaS = new AreaSs(reader);
            Task.Run(async () => await areaS.Load())
                .ContinueWith(_ => this.AreaSs = areaS.List);

            var categoryL = new CategoryLs(reader);
            Task.Run(async () => await categoryL.Load())
                .ContinueWith(_ => this.CategoryLs = categoryL.List);

            var categoryS = new CategorySs(reader);
            Task.Run(async () => await categoryS.Load())
                .ContinueWith(_ => this.CategorySs = categoryS.List);

            this.ResetAreaCommand = new DelegateCommand(() => this.SelectedPref = null);
            this.SearchCommand = new DelegateCommand(this.OnSearch);

        }

        private async void OnSearch()
        {
            var reader = new HttpDataReader();
            var param = new Dictionary<string, string>();

            var selectedArea = CreateSearchAreaCondition();
            if (!selectedArea.Key.Equals(string.Empty))
            {
                param.Add(selectedArea.Key, selectedArea.Value);
            }

            var selectedCategory = CreateSearchCategoryCondition();
            if (!selectedCategory.Key.Equals(string.Empty))
            {
                param.Add(selectedCategory.Key, selectedCategory.Value);
            }

            var rests = await new Rests(reader).Get(param);
            this.Rests = rests.List;
        }

        private KeyValuePair<string, string> CreateSearchAreaCondition()
        {
            if (!string.IsNullOrWhiteSpace(this.SelectedAreaS))
            {
                return new KeyValuePair<string, string>("areacode_s", this.SelectedAreaS);
            }

            if (!string.IsNullOrWhiteSpace(this.SelectedAreaM))
            {
                return new KeyValuePair<string, string>("areacode_m", this.SelectedAreaM);
            }

            if (!string.IsNullOrWhiteSpace(this.SelectedAreaL))
            {
                return new KeyValuePair<string, string>("areacode_l", this.SelectedAreaL);
            }

            if (!string.IsNullOrWhiteSpace(this.SelectedPref))
            {
                return new KeyValuePair<string, string>("pref", this.SelectedPref);
            }

            if (!string.IsNullOrWhiteSpace(this.SelectedArea))
            {
                return new KeyValuePair<string, string>("area", this.SelectedArea);
            }

            return new KeyValuePair<string, string>(string.Empty, string.Empty);
        }

        private KeyValuePair<string, string> CreateSearchCategoryCondition()
        {
            if (!string.IsNullOrWhiteSpace(this.SelectedCategoryS))
            {
                return new KeyValuePair<string, string>("category_s", this.SelectedCategoryS);
            }

            if (!string.IsNullOrWhiteSpace(this.SelectedCategoryL))
            {
                return new KeyValuePair<string, string>("category_l", this.SelectedCategoryL);
            }
            return new KeyValuePair<string, string>(string.Empty, string.Empty);
        }
    }
}
