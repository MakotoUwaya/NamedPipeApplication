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
                    return this.areaLs.Where(a => this.Prefs.Contains(a.Pref));
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
                    return this.areaMs.Where(a => this.Prefs.Contains(a.Pref));
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
                    return this.areaSs.Where(a => this.Prefs.Contains(a.Pref));
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

        private string freeWord;
        public string FreeWord
        {
            get { return this.freeWord; }
            set
            {
                this.freeWord = value;
                this.RaisePropertyChanged(nameof(this.FreeWord));
            }
        }

        private string shopName;
        public string ShopName
        {
            get { return this.shopName; }
            set
            {
                this.shopName = value;
                this.RaisePropertyChanged(nameof(this.ShopName));
            }
        }

        private Rests rests;
        public Rests Rests
        {
            get
            {
                return this.rests;
            }
            set
            {
                this.rests = value;
                this.RaisePropertyChanged(nameof(this.Rests));
                this.RaisePropertyChanged(nameof(this.PageCount));
                this.PagePreviewCommand.RaiseCanExecuteChanged();
                this.PageNextCommand.RaiseCanExecuteChanged();
            }
        }

        public bool CanPrevPage()
        {
            if (this.Rests == null)
            {
                return false;
            }
            return 1 < this.Rests.PageOffset;
        }

        public bool CanNextPage()
        {
            if (this.Rests == null)
            {
                return false;
            }
            return this.Rests.PageOffset < this.MaxPageCount;
        }

        public int MaxPageCount
        {
            get
            {
                if (this.Rests == null || this.Rests.TotalHitCount == 0)
                {
                    return 0;
                }
                return (this.Rests.TotalHitCount / this.Rests.HitPerPage) +
                    (0 < this.Rests.TotalHitCount % this.Rests.HitPerPage ? 1 : 0);
            }
        }

        public string PageCount
        {
            get
            {
                if (this.Rests == null)
                {
                    return "0";
                }
                return $"{this.Rests.PageOffset:N0} / {this.MaxPageCount:N0}";
            }
        }

        public DelegateCommand SearchCommand { get; set; }

        public DelegateCommand SearchConditionClearCommand { get; }

        public DelegateCommand PagePreviewCommand { get; set; }

        public DelegateCommand PageNextCommand { get; set; }

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

            this.SearchCommand = new DelegateCommand(this.OnSearch);
            this.SearchConditionClearCommand = new DelegateCommand(this.OnSearchConditionClear);
            this.PagePreviewCommand = new DelegateCommand(this.OnPagePreview, this.CanPrevPage);
            this.PageNextCommand = new DelegateCommand(this.OnPageNext, this.CanNextPage);

        }

        private void OnSearch()
        {
            this.OnSearch(null);            
        }

        private async void OnSearch(IDictionary<string, string> param)
        {
            if (param == null)
            {
                param = new Dictionary<string, string>();
            }

            var reader = new HttpDataReader();
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

            if (!string.IsNullOrWhiteSpace(this.ShopName))
            {               
                param.Add("name", this.ShopName);
            }
            if (!string.IsNullOrWhiteSpace(this.FreeWord))
            {
                param.Add("freeword", string.Join(",", this.FreeWord.Split(',').Take(10)));
            }

            this.Rests = await new Rests(reader).Get(param);
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

        private void OnSearchConditionClear()
        {
            this.SelectedAreaS = string.Empty;
            this.SelectedAreaM = string.Empty;
            this.SelectedAreaL = string.Empty;
            this.SelectedPref = string.Empty;
            this.SelectedArea = string.Empty;
            this.SelectedCategoryS = string.Empty;
            this.SelectedCategoryL = string.Empty;
            this.FreeWord = string.Empty;
        }

        private void OnPagePreview()
        {
            var param = new Dictionary<string, string>
            {
                { "offset_page", $"{this.Rests.PageOffset - 1}" }
            };
            this.OnSearch(param);
        }

        private void OnPageNext()
        {
            var param = new Dictionary<string, string>
            {
                { "offset_page", $"{this.Rests.PageOffset + 1}" }
            };
            this.OnSearch(param);
        }
    }
}
