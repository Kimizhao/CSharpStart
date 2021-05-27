using System;
using System.Linq;
using System.Text;

namespace SqlSugarDemo01
{
    ///<summary>
    ///车辆信息
    ///</summary>
    public partial class VehicleInfo
    {
           public VehicleInfo(){


           }
           /// <summary>
           /// Desc:ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long VehicleInfoID {get;set;}

           /// <summary>
           /// Desc:车架号 VIN
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string VIN {get;set;}

           /// <summary>
           /// Desc:车牌号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LicensePlate {get;set;}

           /// <summary>
           /// Desc:车牌颜色
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LicensePlateColor {get;set;}

           /// <summary>
           /// Desc:车体结构
           /// Default:
           /// Nullable:True
           /// </summary>           
           public byte? CarBodyStructure {get;set;}

           /// <summary>
           /// Desc:车辆颜色
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VehicleColor {get;set;}

           /// <summary>
           /// Desc:核定载重
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AuthorizedLoad {get;set;}

           /// <summary>
           /// Desc:车辆尺寸（长）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VehicleLength {get;set;}

           /// <summary>
           /// Desc:车辆尺寸（宽）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VehicleWidth {get;set;}

           /// <summary>
           /// Desc:车辆尺寸（高）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VehicleHeight {get;set;}

           /// <summary>
           /// Desc:总质量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TotalMass {get;set;}

           /// <summary>
           /// Desc:车辆类型
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? VehicleType {get;set;}

           /// <summary>
           /// Desc:行业类型
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? BusinessType {get;set;}

           /// <summary>
           /// Desc:车辆型号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VehicleModelID {get;set;}

           /// <summary>
           /// Desc:购买时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? BuyTime {get;set;}

           /// <summary>
           /// Desc:行驶证号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DrivingLicense {get;set;}

           /// <summary>
           /// Desc:发动机编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EngineCode {get;set;}

           /// <summary>
           /// Desc:车籍地
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VehicleSite {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public byte? TechnicalLevel {get;set;}

           /// <summary>
           /// Desc:出厂日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ProductionDate {get;set;}

           /// <summary>
           /// Desc:等级评定日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? RatingDate {get;set;}

           /// <summary>
           /// Desc:二级维护日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SecMaintenanceDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public byte? SecMaintenanceStatus {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public byte? AnnualReviewStatus {get;set;}

           /// <summary>
           /// Desc:年检有效期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AnnualInspectionPeriod {get;set;}

           /// <summary>
           /// Desc:保险有效期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InsurancePeriod {get;set;}

           /// <summary>
           /// Desc:保养有效期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MaintenanceValidity {get;set;}

           /// <summary>
           /// Desc:所属单位名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AffiliatedUnit {get;set;}

           /// <summary>
           /// Desc:车辆联系人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VehicleContactPerson {get;set;}

           /// <summary>
           /// Desc:车辆联系电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VehicleContactNum {get;set;}

           /// <summary>
           /// Desc:车辆 sim 卡号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SimcardNum {get;set;}

           /// <summary>
           /// Desc:车辆注册时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? VehicleRegistDate {get;set;}

           /// <summary>
           /// Desc:所属组织 ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AreasID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public byte? EPAVehicleType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public byte? TrafficDeptVehicleType {get;set;}

           /// <summary>
           /// Desc:发动机型号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EngineInfoID {get;set;}

           /// <summary>
           /// Desc:所有者地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OwnerAddress {get;set;}

           /// <summary>
           /// Desc:车牌型号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LicensePlateType {get;set;}

           /// <summary>
           /// Desc:行政区划
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AdministrativeArea {get;set;}

           /// <summary>
           /// Desc:行政地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AdministrativeAddress {get;set;}

           /// <summary>
           /// Desc:总客数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? TotalCustomer {get;set;}

           /// <summary>
           /// Desc:整备质量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UnladenMass {get;set;}

           /// <summary>
           /// Desc:列车最大总质量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MaxTotalMass {get;set;}

           /// <summary>
           /// Desc:入网证号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RegistrationCard {get;set;}

           /// <summary>
           /// Desc:初次登记日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? InitialRegistrationDate {get;set;}

           /// <summary>
           /// Desc:年检日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? AnnualInspectionDate {get;set;}

           /// <summary>
           /// Desc:强制报废日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? MandatoryRetireDate {get;set;}

           /// <summary>
           /// Desc:企业简称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EnterpriseAbbreviation {get;set;}

           /// <summary>
           /// Desc:SN
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SN {get;set;}

           /// <summary>
           /// Desc:车型协议
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VehicleAgreement {get;set;}

           /// <summary>
           /// Desc:终端编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TerminalManaID {get;set;}

           /// <summary>
           /// Desc:ICCID号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ICCID {get;set;}

           /// <summary>
           /// Desc:车辆详情
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VehicleDesc {get;set;}

           /// <summary>
           /// Desc:道路运输证号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RoadTransporCertifi {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateTime {get;set;}

           /// <summary>
           /// Desc:修改日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdateTime {get;set;}

           /// <summary>
           /// Desc:车辆出厂编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FactoryNumber {get;set;}

           /// <summary>
           /// Desc:终端型号编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TerminalModelID {get;set;}

           /// <summary>
           /// Desc:安全芯片编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SecureChipManaID {get;set;}

           /// <summary>
           /// Desc:软件版本号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SoftwareVersions {get;set;}

           /// <summary>
           /// Desc:硬件版本号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HardwareVersion {get;set;}

           /// <summary>
           /// Desc:激活模式
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public byte? RegisterMode {get;set;}

           /// <summary>
           /// Desc:备案状态
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public byte? PutOnRecordEstate {get;set;}

           /// <summary>
           /// Desc:申请序号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RequestID {get;set;}

           /// <summary>
           /// Desc:安全芯片型号ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SecureChipModelID {get;set;}

           /// <summary>
           /// Desc:驾驶员电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DriverTel {get;set;}

           /// <summary>
           /// Desc:驾驶员姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DriverName {get;set;}

    }
}
