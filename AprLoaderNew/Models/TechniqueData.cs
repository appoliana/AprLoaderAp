using AprLoaderNew.ViewModel;
using System.Collections.ObjectModel;

namespace AprLoaderNew.Models
{
    public static class TechniqueData
    {
        public static ObservableCollection<TechniqueEnum> Technique = new ObservableCollection<TechniqueEnum> { TechniqueEnum.Графия, TechniqueEnum.СерийнаяГрафия,
                                                                                TechniqueEnum.Скопия, TechniqueEnum.СкопияHD,
                                                                                TechniqueEnum.Томосинтез, TechniqueEnum.Томография };
        
        public static ObservableCollection<string> WorkStations = new ObservableCollection<string>();
    }
}
