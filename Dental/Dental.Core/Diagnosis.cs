using System.ComponentModel;

namespace Dental.Core
{
    public enum Diagnosis
    {
        [Description("Кариес")]
        Caries  = 1 ,

        [Description("Пульпит")]
        Pulpits,         

        [Description("Периодонтит")]
        Periodontitis,

        [Description("Aмфодонтоз")]
        Amphodontosis,

        [Description("Пломбированный")]
        Sealed,          
         
        [Description("Отсутствует зуб")]
        MissingTooth ,

        [Description("Искусственный зуб")]
        AnArtificialToot
    }
}
