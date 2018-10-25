using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPOManagement.Models
{
    public enum AssetType {
        WEEDER, TILLER, TRACTOR, SPRAYER, DRILLER, HARVESTER, STORAGE_FACILITY, TWO_WHEELER, FOUR_WHEELER
    }

    public enum LiveStockAssetType
    {
        COW, BUFFALO, BULL, SHEEP, GOAT, POULTRY
    }

    public enum HouseAssetType {
        MIXER, GRINDER, WASHING_MACHINE, COMPUTER, TV, AIR_CONDITIONER
    }

    public enum HouseType {
        PUCCA, THATCHED, TILED, SHED
    }

    public enum LandType {
        WET, DRY, GARDEN, FALLOW, KITCHEN
    }

    public enum IrrigrationSource {
        BORE, OPEN_WELL, TANK, RAIN_FED
    }


    public abstract class Asset
    {
        public int AssetID { get; set; }

        [Display(Name = "Asset Type")]
        public AssetType AssetType { get; set; }

        [Display(Name = "Total number of Asset")]
        public int Count { get; set; }


        [Display(Name = "Livestock Type")]
        public LiveStockAssetType LiveStockAssetType { get; set; }

        [Display(Name = "House Type")]
        public HouseType HouseType { get; set; }

        [Display(Name = "House Asset Type")]
        public HouseAssetType HouseAssetType { get; set; }

        [Display(Name = "Land Type")]
        public LandType LandType { get; set; }

        [Display(Name = "Does the member own the asset?")]
        public bool DoesOwn { get; set; }

        [Display(Name = "Source of Irrigation")]
        public IrrigrationSource IrrigrationSource { get; set; }

        [Display(Name = "Pump Type")]
        public string PumpType { get; set; }

        [Display(Name = "Total acreage")]
        public double Acreage { get; set; }

        [Display(Name = "Land zone")]
        public string Zone { get; set; }

        [Display(Name = "Land SRO")]
        public string SRO { get; set; }

        [Display(Name = "Land Village")]
        public string Village { get; set; }

        [Display(Name = "Land Survey Number")]
        public string SurveyNumber { get; set; }

    }

    public class MemberAsset : Asset {
        public int MemberAssetID { get; set; }
        public int MemberID { get; set; }
        public virtual Member Member { get; set; }

    }

    public class FPOAsset: Asset {
        public int FPOAssetID { get; set; }
        public int FPOID { get; set; }
        public virtual FPO FPO { get; set; }
    }

 

}
