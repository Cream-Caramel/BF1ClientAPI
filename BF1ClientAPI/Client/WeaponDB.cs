using BF1ClientAPI.Utils;

namespace BF1ClientAPI.Client;

public static class WeaponDB
{
    /// <summary>
    /// 全部武器信息，ShortName不超过16个字符
    /// </summary>
    public readonly static List<WeaponInfo> AllWeaponInfo = new()
    {
        // 公用配枪
        new() { Guid="3CE86D7C-9951-4B25-9FD6-A97CA94F4A20", Kind="公用配枪", English="U_M1911", Chinese="M1911", ShortName="M1911", ImageName="Colt1911-ed324bf1.png" },
        new() { Guid="009736C2-B237-49AE-9DD1-E77AF7771FF2", Kind="公用配枪", English="U_LugerP08", Chinese="P08 手枪", ShortName="P08", ImageName="LugerP08-7f07aa2d.png" },
        new() { Guid="A666D907-0F72-4641-B43A-6AA756FFBC03", Kind="公用配枪", English="U_FN1903", Chinese="Mle 1903", ShortName="M1903", ImageName="Mle1903-a0fe1ec3.png" },
        new() { Guid="4DD1FAD2-1CF1-496C-BE29-BDAEBC931D74", Kind="公用配枪", English="U_BorchardtC93", Chinese="C93", ShortName="C93", ImageName="Mle1903-a0fe1ec3.png" },
        new() { Guid="87643E53-CD17-FFC4-167B-AA72301A323A", Kind="公用配枪", English="U_SmithWesson", Chinese="3 号左轮手枪", ShortName="No3 Rev", ImageName="SmithWesson-e26b4f24.png" },
        new() { Guid="33F9105C-40C7-3980-7982-ADD4B9F6311A", Kind="公用配枪", English="U_Kolibri", Chinese="Kolibri", ShortName="Kolibri", ImageName="KolibriPistol-ec20b160.png" },
        new() { Guid="64503392-4DDF-435D-8ABA-22730383E073", Kind="公用配枪", English="U_NagantM1895", Chinese="纳甘左轮手枪", ShortName="Nagant Rev", ImageName="NagantM1895-05035f4a.png" },
        new() { Guid="84AF0AF5-D981-48BE-8665-CC24A278DA6E", Kind="公用配枪", English="U_Obrez", Chinese="Obrez 手枪", ShortName="Obrez", ImageName="ObrezPistol-0c86b6ed.png" },
        new() { Guid="8680EFC0-CA02-43E0-8CA2-591FB279DD95", Kind="公用配枪", English="U_Webley_Mk6", Chinese="Mk VI 左轮手枪", ShortName="Mk VI", ImageName="Webley_MK6-da81b474.png" },
        new() { Guid="AF3F421B-F68B-401D-94B4-B982EE6C8A91", Kind="公用配枪", English="U_M1911_Preorder_Hellfighter", Chinese="地狱战士 M1911", ShortName="M1911 HF", ImageName="Colt1911-ed324bf1.png" },
        new() { Guid="B97A8C29-A567-437F-9B6C-9E1E8FD86BF9", Kind="公用配枪", English="U_LugerP08_Wep_Preorder", Chinese="红男爵的 P08", ShortName="P08 HNJ", ImageName="LugerP08-7f07aa2d.png" },
        new() { Guid="5962340E-AED8-4B93-A10E-D7C91FFD2460", Kind="公用配枪", English="U_M1911_Suppressed", Chinese="M1911（消音器）", ShortName="M1911 XYQ", ImageName="M1911Silencer-d6c0e687.png" },
        new() { Guid="B9333E7C-3D7D-4147-A569-9FC9BB2B4F5D", Kind="公用配枪", English="U_SingleActionArmy", Chinese="维和左轮 Peacekeeper", ShortName="Peacekeeper", ImageName="Colt_SAA-ef15294c.png" },
        new() { Guid="F7CED576-7629-402A-8598-4A4998C02E0A", Kind="公用配枪", English="U_M1911_Preorder_Triforce", Chinese="步兵小子 M1911", ShortName="M1911 BBXZ", ImageName="Colt1911-ed324bf1.png" },
        
        // 手榴弹
        new() { Guid="F0B75644-5B3F-45CD-9E42-9B67F3D4D37F", Kind="手榴弹", English="U_GermanStick", Chinese="破片手榴弹", ShortName="German Stick", ImageName="GadgetFragmented-8c15152e.png" },
        new() { Guid="F0B75644-5B3F-45CD-9E42-9B67F3D4D37F", Kind="手榴弹", English="U_FragGrenade", Chinese="棒式手榴弹", ShortName="Frag Grenade", ImageName="GadgetFragmented-8c15152e.png" },
        new() { Guid="EE6AC80E-FFDF-4E5A-923D-209CE9B86BF4", Kind="手榴弹", English="U_GasGrenade", Chinese="毒气手榴弹", ShortName="Gas Grenade", ImageName="GadgetGas-2bee4386.png" },
        new() { Guid="F9A8C36F-F5B6-4946-B3B9-F5923564CD51", Kind="手榴弹", English="U_ImpactGrenade", Chinese="冲击手榴弹", ShortName="Impact Grenade", ImageName="GadgetImpact-f0c7f39e.png" },
        new() { Guid="8219207A-41E6-4ED2-A3E8-9690752EC40C", Kind="手榴弹", English="U_Incendiary", Chinese="燃烧手榴弹", ShortName="Incendiary", ImageName="GadgetIncindiary-68d49a3a.png" },
        new() { Guid="67B5683D-D897-4881-BB86-DACB9947264E", Kind="手榴弹", English="U_MiniGrenade", Chinese="小型手榴弹", ShortName="Mini Grenade", ImageName="GadgetMiniOffensive-2d19e08a.png" },
        new() { Guid="04CDC06B-F4B6-4696-BE9C-08E1D0D36347", Kind="手榴弹", English="U_SmokeGrenade", Chinese="烟雾手榴弹", ShortName="Smoke Grenade", ImageName="GadgetSmoke-af84f434.png" },
        new() { Guid="D4A99456-2ABA-4376-9870-200FD24C5D45", Kind="手榴弹", English="U_Grenade_AT", Chinese="轻型反坦克手榴弹", ShortName="Grenade AT", ImageName="GadgetTrooperATGrenade-a6575030.png" },
        new() { Guid="55D01566-4322-4EAE-AD13-9DDAF2C2F399", Kind="手榴弹", English="U_ImprovisedGrenade", Chinese="土制手榴弹", ShortName="Imsp Grenade", ImageName="ImprovisedGrenade-fea87071.png" },
        new() { Guid="DD1BBA84-A6AB-4A66-986F-2B2556F6E7B1", Kind="手榴弹", English="U_RussianBox", Chinese="俄罗斯标准手榴弹", ShortName="Russian Box", ImageName="RU_Grenade-a7e29a54.png" },

        ////////////////////////////////// 突击兵 Assault //////////////////////////////////

        // 突击兵 主要武器
        new() { Guid="16D7C222-5ACA-4728-854D-6282E44846DC", Kind="突击兵 主要武器", English="U_RemingtonM10_Wep_Slug", Chinese="Model 10-A（霰弹块）", ShortName="10A XDK", ImageName="RemingtonM10-08ab3f5b.png" },
        new() { Guid="508E534A-A7A5-41A1-8F8F-FEDFA0AFDA93", Kind="突击兵 主要武器", English="U_RemingtonM10_Wep_Choke", Chinese="Model 10-A（猎人）", ShortName="10A LR", ImageName="RemingtonM10-08ab3f5b.png" },
        new() { Guid="ED262207-65C8-46E1-B5D4-D7468143790F", Kind="突击兵 主要武器", English="U_RemingtonM10", Chinese="Model 10-A（原厂）", ShortName="10A YC", ImageName="RemingtonM10-08ab3f5b.png" },
        new() { Guid="9F97B37E-2A81-4AE3-A96A-4402B30BF184", Kind="突击兵 主要武器", English="U_Winchester1897_Wep_Sweeper", Chinese="M97 战壕枪（扫荡）", ShortName="M97 SD", ImageName="WinchesterM1897-bb453195.png" },
        new() { Guid="EA7C6CF1-5801-4C52-8685-51B4C7B90CE9", Kind="突击兵 主要武器", English="U_Winchester1897_Wep_LowRecoil", Chinese="M97 战壕枪（Back-Bored）", ShortName="M97 BB", ImageName="WinchesterM1897-bb453195.png" },
        new() { Guid="20D21E3D-BA5F-4239-8F90-42FCDDA12F51", Kind="突击兵 主要武器", English="U_Winchester1897_Wep_Choke", Chinese="M97 战壕枪（猎人）", ShortName="M97 LR", ImageName="WinchesterM1897-bb453195.png" },
        new() { Guid="ADA8C89D-F213-401C-806C-B60483E2EEE7", Kind="突击兵 主要武器", English="U_MP18_Wep_Trench", Chinese="MP 18（壕沟战）", ShortName="MP18 HGZ", ImageName="BergmannSchmeisserMP18-761af430.png" },
        new() { Guid="A498D568-2F50-449C-BA5D-6864AB34F8D2", Kind="突击兵 主要武器", English="U_MP18_Wep_Burst", Chinese="MP 18（实验）", ShortName="MP18 SY", ImageName="BergmannSchmeisserMP18-761af430.png" },
        new() { Guid="765A6856-3A80-4196-8DB6-14A95B94AB85", Kind="突击兵 主要武器", English="U_MP18_Wep_Accuracy", Chinese="MP 18（瞄准镜）", ShortName="MP18 MZJ", ImageName="BergmannSchmeisserMP18-761af430.png" },
        new() { Guid="58E00507-4123-49D9-A9DE-0F5C7A267CC4", Kind="突击兵 主要武器", English="U_BerettaM1918_Wep_Trench", Chinese="M1918 自动冲锋枪（壕沟战）", ShortName="MP1918 HGZ", ImageName="Beretta1918-3daab991.png" },
        new() { Guid="29539D1A-A492-4398-BABF-6BC8DBD4BECA", Kind="突击兵 主要武器", English="U_BerettaM1918_Wep_Stability", Chinese="M1918 自动冲锋枪（冲锋）", ShortName="MP1918 CF", ImageName="Beretta1918-3daab991.png" },
        new() { Guid="2439B810-3ACD-4069-B1E9-0CDC2CE51985", Kind="突击兵 主要武器", English="U_BerettaM1918", Chinese="M1918 自动冲锋枪（原厂）", ShortName="MP1918 YC", ImageName="Beretta1918-3daab991.png" },
        new() { Guid="FA78AFDF-D06D-4CBE-B325-945F9B4091C3", Kind="突击兵 主要武器", English="U_BrowningA5_Wep_LowRecoil", Chinese="12g 自动霰弹枪（Back-Bored）", ShortName="12g BB", ImageName="BrowingA5-95b260b4.png" },
        new() { Guid="31D6D032-5B6F-4494-A04A-0FB8EDB130BB", Kind="突击兵 主要武器", English="U_BrowningA5_Wep_Choke", Chinese="12g 自动霰弹枪（猎人）", ShortName="12g LR", ImageName="BrowingA5-95b260b4.png" },
        new() { Guid="D7A0DED9-EC54-4523-9294-656FA1881FE9", Kind="突击兵 主要武器", English="U_BrowningA5_Wep_ExtensionTube", Chinese="12g 自动霰弹枪（加长）", ShortName="12g JC", ImageName="BrowingA5-95b260b4.png" },
        new() { Guid="2B253855-7BA0-4FF6-9F25-57D53B15FE32", Kind="突击兵 主要武器", English="U_Hellriegel1915", Chinese="Hellriegel 1915（原厂）", ShortName="H1915 YC", ImageName="Hellriegel1915-e2513c1e.png" },
        new() { Guid="B1E5A3BC-3D24-4FE5-84D1-4523D6DCE545", Kind="突击兵 主要武器", English="U_Hellriegel1915_Wep_Accuracy", Chinese="Hellriegel 1915（防御）", ShortName="H1915 FY", ImageName="Hellriegel1915-e2513c1e.png" },
        new() { Guid="8F241031-A76D-436B-AE5F-CD797B504A7A", Kind="突击兵 主要武器", English="U_Winchester1897_Wep_Preorder", Chinese="地狱战士战壕霰弹枪", ShortName="M97 DYZS", ImageName="WinchesterM1897-bb453195.png" },
        new() { Guid="5D89166E-58E1-46FD-B854-69641E9DCEF7", Kind="突击兵 主要武器", English="U_SjogrenShotgun", Chinese="Sj?gren Inertial（原厂）", ShortName="RDP YC", ImageName="SjogrenShotgun-e95b3db0.png" },
        new() { Guid="42B442BF-6ACE-4592-A53B-96424B4ACABF", Kind="突击兵 主要武器", English="U_SjogrenShotgun_Wep_Slug", Chinese="Sj?gren Inertial（霰弹块）", ShortName="RDP XDK", ImageName="SjogrenShotgun-e95b3db0.png" },
        new() { Guid="6B07DE60-5568-43C0-B1F6-D51A13A9BD3C", Kind="突击兵 主要武器", English="U_Ribeyrolles", Chinese="利贝罗勒 1918（原厂）", ShortName="L1918 YC", ImageName="Ribeyrolles-0e43197c.png" },
        new() { Guid="C4B84F0E-D7FF-49D9-9796-E6CF95C058BD", Kind="突击兵 主要武器", English="U_Ribeyrolles_Wep_Optical", Chinese="Ribeyrolles 1918（瞄准镜）", ShortName="L1918 MZJ", ImageName="Ribeyrolles-0e43197c.png" },
        new() { Guid="CCA1F8F7-5658-4DCA-BAA8-2C930C2EF5F0", Kind="突击兵 主要武器", English="U_RemingtonModel1900", Chinese="Model 1900（原厂）", ShortName="M1900 YC", ImageName="RemingtonModel1900-e80b885b.png" },
        new() { Guid="55381B1D-7E17-44BE-AC0B-33542A64BF96", Kind="突击兵 主要武器", English="U_RemingtonModel1900_Wep_Slug", Chinese="Model 1900（霰弹块）", ShortName="M1900 XDK", ImageName="RemingtonModel1900-e80b885b.png" },
        new() { Guid="C4F8BC18-1908-4A83-ABB6-B812C05D49CE", Kind="突击兵 主要武器", English="U_MaximSMG", Chinese="SMG 08/18（原厂）", ShortName="SMG0818 YC", ImageName="MaximSMG-c3563db7.png" },
        new() { Guid="DEC97287-AF0B-49E4-8FD8-CBC5FB5AF497", Kind="突击兵 主要武器", English="U_MaximSMG_Wep_Accuracy", Chinese="SMG 08/18（瞄准镜）", ShortName="SMG0818 MZJ", ImageName="MaximSMG-c3563db7.png" },
        new() { Guid="E1297C9B-861A-4170-840B-83AC64A0C574", Kind="突击兵 主要武器", English="U_SteyrM1912_P16", Chinese="M1912/P.16（冲锋）", ShortName="M1912 P.16 CF", ImageName="SteyrM1912Stock-a1ad884f.png" },
        new() { Guid="39137F1F-B794-4265-BB30-490E1E182F81", Kind="突击兵 主要武器", English="U_SteyrM1912_P16_Wep_Burst", Chinese="Maschinenpistole M1912/P.16（实验）", ShortName="M1912 P.16 SY", ImageName="SteyrM1912Stock-a1ad884f.png" },
        new() { Guid="1C5B531F-26B4-429F-839B-99252610A7F0", Kind="突击兵 主要武器", English="U_Mauser1917Trench", Chinese="M1917 战壕卡宾枪", ShortName="M1917 KBQ ZH", ImageName="MauserM1917TrenchCarbine-9a4158a1.png" },
        new() { Guid="245A23B1-53BA-4AB2-A416-224794F15FCB", Kind="突击兵 主要武器", English="U_Mauser1917Trench_Wep_Scope", Chinese="M1917 卡宾枪（巡逻）", ShortName="M1917 KBQ XL", ImageName="MauserM1917TrenchCarbine-9a4158a1.png" },
        new() { Guid="6C3EE48B-0974-48B1-AFF7-96FD4D684E82", Kind="突击兵 主要武器", English="U_ChauchatSMG", Chinese="RSC 冲锋枪（原厂）", ShortName="RSC YC", ImageName="Chauchat-Ribeyrolles-4af8a912.png" },
        new() { Guid="6DAFDE21-2502-41B4-878B-532E70905238", Kind="突击兵 主要武器", English="U_ChauchatSMG_Wep_Optical", Chinese="RSC 冲锋枪（瞄准镜）", ShortName="RSC MZJ", ImageName="Chauchat-Ribeyrolles-4af8a912.png" },
        new() { Guid="C70FE9E0-0A1C-470C-B377-68059953EAD8", Kind="突击兵 主要武器", English="U_M1919Thompson_Wep_Trench", Chinese="Annihilator（壕沟）", ShortName="Annihilator HG", ImageName="ThompsonAnnihilatorTr-1a660e74.png" },
        new() { Guid="DBC25B43-29D9-4FB4-B9EF-C4966CD773B3", Kind="突击兵 主要武器", English="U_M1919Thompson_Wep_Stability", Chinese="Annihilator（冲锋）", ShortName="Annihilator CF", ImageName="ThompsonAnnihilatorTr-1a660e74.png" },
        new() { Guid="A9985C95-7364-4AE3-BC77-C53651128EBE", Kind="突击兵 主要武器", English="U_M1919Thompson", Chinese="M1919 冲锋枪", ShortName="M1919", ImageName="M1919Thompson-1cf7343d.png" },
        new() { Guid="D8AEB334-58E2-4A52-83BA-F3C2107196F0", Kind="突击兵 主要武器", English="U_FrommerStopAuto", Chinese="费罗梅尔停止手枪（自动）", ShortName="FrommerStopAuto", ImageName="FrommerStop-506df97e.png" },
        new() { Guid="7085A5B9-6A77-4766-83CD-3666DA3EDF28", Kind="突击兵 主要武器", English="U_SawnOffShotgun", Chinese="短管霰弹枪", ShortName="SawnOffShotgun", ImageName="SawedOfShotgun-d31e0dd8.png" },

        // 突击兵 配枪
        new() { Guid="F5F1FAA5-1791-441F-BDB5-82F9A4D14BAF", Kind="突击兵 配枪", English="U_GasserM1870", Chinese="加塞 M1870", ShortName="M1870", ImageName="GasserM1870-00471df4.png" },
        new() { Guid="25B28666-332D-4FCB-AD68-18184AD37702", Kind="突击兵 配枪", English="U_LancasterHowdah", Chinese="Howdah 手枪", ShortName="Howdah", ImageName="LancasterHowdah-9100578c.png" },
        new() { Guid="E0C46F74-92CF-0C0C-E475-806B37E14706", Kind="突击兵 配枪", English="U_Hammerless", Chinese="1903 Hammerless", ShortName="1903", ImageName="Hammerless-e61505d4.png" },

        // 突击兵 配备一二
        new() { Guid="079D8793-073C-4332-A959-19C74A9D2A46", Kind="突击兵 配备一二", English="U_Dynamite", Chinese="炸药", ShortName="Dynamite", ImageName="GadgetDynamite-b6283212.png" },
        new() { Guid="72CCBF3E-C0FE-4657-A1A7-EACDB2D11985", Kind="突击兵 配备一二", English="U_ATGrenade", Chinese="反坦克手榴弹", ShortName="ATGrenade", ImageName="GadgetATGrenade-4b135d46.png" },
        new() { Guid="6DFD1536-BBBB-4528-917A-7E2821FB4B6B", Kind="突击兵 配备一二", English="U_ATMine", Chinese="反坦克地雷", ShortName="ATMine", ImageName="GadgetMine-527cef72.png" },
        new() { Guid="BE041F1A-460B-4FD5-9E4B-F1C803C0F42F", Kind="突击兵 配备一二", English="U_BreechGun", Chinese="反坦克火箭炮", ShortName="AT", ImageName="GadgetBreechgun-f2188c3f.png" },
        new() { Guid="AE96B513-1F05-4E63-A273-E98FA91EE4D0", Kind="突击兵 配备一二", English="U_BreechGun_Flak", Chinese="防空火箭炮", ShortName="AAT", ImageName="AA-Rocket-Gun-49a4e8d1.png" },

        ////////////////////////////////// 医疗兵 Medic //////////////////////////////////

        // 医疗兵 主要武器
        new() { Guid="DE3E0902-9C36-4CFA-B872-49282591F11C", Kind="医疗兵 主要武器", English="U_CeiRigottiM1895_Wep_Trench", Chinese="Cei-Rigotti（壕沟战）", ShortName="M1895 HGZ", ImageName="CeiRigotti-8ae129e0.png" },
        new() { Guid="D71DA743-8F97-430B-A794-50F7974C28EC", Kind="医疗兵 主要武器", English="U_CeiRigottiM1895_Wep_Range", Chinese="Cei-Rigotti（瞄准镜）", ShortName="M1895 MZJ", ImageName="CeiRigotti-8ae129e0.png" },
        new() { Guid="12EE7056-0D58-4570-ADA6-06D9062DE408", Kind="医疗兵 主要武器", English="U_CeiRigottiM1895", Chinese="Cei-Rigotti（原厂）", ShortName="M1895 YC", ImageName="CeiRigotti-8ae129e0.png" },
        new() { Guid="EDF7E9DB-5847-4E21-9EF0-C1E01ED80D8B", Kind="医疗兵 主要武器", English="U_MauserSL1916_Wep_Scope", Chinese="Selbstlader M1916（神射手）", ShortName="M1916 SSS", ImageName="MauserSelbstladerM1916-c86e8775.png" },
        new() { Guid="88336091-0676-4B12-BA91-810C25ED67C4", Kind="医疗兵 主要武器", English="U_MauserSL1916_Wep_Range", Chinese="Selbstlader M1916（瞄准镜）", ShortName="M1916 MZJ", ImageName="MauserSelbstladerM1916-c86e8775.png" },
        new() { Guid="3DCA71EC-EBCC-464C-B3CD-7251372FC0AD", Kind="医疗兵 主要武器", English="U_MauserSL1916", Chinese="Selbstlader M1916（原厂）", ShortName="M1916 YC", ImageName="MauserSelbstladerM1916-c86e8775.png" },
        new() { Guid="2DFEF12D-7110-47F9-9185-78A081BDE76A", Kind="医疗兵 主要武器", English="U_WinchesterM1907_Wep_Trench", Chinese="M1907 半自动步枪（壕沟战）", ShortName="M1907 JGZ", ImageName="WinchesterM1907-3e99346c.png" },
        new() { Guid="A9507FBD-8B45-49E6-803C-53A5D5EE0406", Kind="医疗兵 主要武器", English="U_WinchesterM1907_Wep_Auto", Chinese="M1907 半自动步枪（扫荡）", ShortName="M1907 SD", ImageName="WinchesterM1907-3e99346c.png" },
        new() { Guid="DD36E432-B119-4D0F-95A1-541493BF7EE6", Kind="医疗兵 主要武器", English="U_WinchesterM1907", Chinese="M1907 半自动步枪（原厂）", ShortName="M1907 YC", ImageName="WinchesterM1907-3e99346c.png" },
        new() { Guid="08AD9E6C-D453-48F4-BDE5-CF84652A12F0", Kind="医疗兵 主要武器", English="U_Mondragon_Wep_Range", Chinese="蒙德拉贡步枪（瞄准镜）", ShortName="Mondragon MZJ", ImageName="Mondragon-a3950be7.png" },
        new() { Guid="EDECA6B4-795F-45B2-BD3F-967E96D40C7D", Kind="医疗兵 主要武器", English="U_Mondragon_Wep_Stability", Chinese="蒙德拉贡步枪（冲锋）", ShortName="Mondragon CF", ImageName="Mondragon-a3950be7.png" },
        new() { Guid="BEB31317-EBBF-45FB-A102-0E115DAA5551", Kind="医疗兵 主要武器", English="U_Mondragon_Wep_Bipod", Chinese="蒙德拉贡步枪（狙击手）", ShortName="Mondragon JJS", ImageName="Mondragon-a3950be7.png" },
        new() { Guid="1F42E46E-603B-4325-AA42-31B86210D47C", Kind="医疗兵 主要武器", English="U_RemingtonModel8", Chinese="自动装填步枪 8.35（原厂）", ShortName="8.35 YC", ImageName="RemingtonM8_Special-398391d9.png" },
        new() { Guid="2066B449-91C9-4B9C-8C4C-40F5B9F0A58E", Kind="医疗兵 主要武器", English="U_RemingtonModel8_Wep_Scope", Chinese="自动装填步枪 8.35（神射手）", ShortName="8.35 SSS", ImageName="RemingtonM8_Special-398391d9.png" },
        new() { Guid="9E7BE0C2-E44D-4B4F-99A7-B05D4451D254", Kind="医疗兵 主要武器", English="U_RemingtonModel8_Wep_ExtendedMag", Chinese="自动装填步枪 8.25（加长）", ShortName="8.25 JC", ImageName="RemingtonM8_Special-398391d9.png" },
        new() { Guid="47BEB21C-2CD6-4ED0-8253-33F8F980EB94", Kind="医疗兵 主要武器", English="U_Luger1906", Chinese="Selbstlader 1906（原厂）", ShortName="1906 YC", ImageName="Luger1906-3238a6b3.png" },
        new() { Guid="5B483B03-DD23-4E38-83C7-CD841A6E9927", Kind="医疗兵 主要武器", English="U_Luger1906_Wep_Scope", Chinese="Selbstlader 1906（狙击手）", ShortName="1906 JJS", ImageName="Luger1906-3238a6b3.png" },
        new() { Guid="F73F9323-CD36-41F6-BFB7-3A2244342E70", Kind="医疗兵 主要武器", English="U_RSC1917_Wep_Range", Chinese="RSC 1917（瞄准镜）", ShortName="RSC 1917 MZJ", ImageName="RSC1917-35904a91.png" },
        new() { Guid="0051C834-6CF9-4CFB-BFBA-E54AF000A9E5", Kind="医疗兵 主要武器", English="U_RSC1917", Chinese="RSC 1917（原厂）", ShortName="RSC 1917 YC", ImageName="RSC1917-35904a91.png" },
        new() { Guid="207B1E7D-B45A-4622-B482-7CAE22C1539F", Kind="医疗兵 主要武器", English="U_FedorovAvtomat_Wep_Trench", Chinese="费德洛夫自动步枪（壕沟战）", ShortName="Fedorov HGZ", ImageName="FederovAvtomat-aa228b15.png" },
        new() { Guid="9E799054-23D4-4525-B777-6A30E99DA964", Kind="医疗兵 主要武器", English="U_FedorovAvtomat_Wep_Range", Chinese="费德洛夫自动步枪（瞄准镜）", ShortName="Fedorov MZJ", ImageName="FederovAvtomat-aa228b15.png" },
        new() { Guid="652BC7DF-9F78-4D93-BF96-2B6F9B6CE75C", Kind="医疗兵 主要武器", English="U_GeneralLiuRifle", Chinese="刘将军步枪（原厂）", ShortName="GeneralLiu YC", ImageName="GeneralLiu-f926d015.png" },
        new() { Guid="52208E58-292B-4B03-90C7-B620C9F582C9", Kind="医疗兵 主要武器", English="U_GeneralLiuRifle_Wep_Stability", Chinese="刘将军步枪（冲锋）", ShortName="GeneralLiu CF", ImageName="GeneralLiu-f926d015.png" },
        new() { Guid="71A33B25-58E3-4F65-90EB-F69042978D99", Kind="医疗兵 主要武器", English="U_FarquharHill_Wep_Range", Chinese="Farquhar-Hill 步枪（瞄准镜）", ShortName="Farquhar MZJ", ImageName="FarquharHill-11f5925b.png" },
        new() { Guid="53884B2B-4DEF-4A02-BEEE-0E7B6D39205E", Kind="医疗兵 主要武器", English="U_FarquharHill_Wep_Stability", Chinese="Farquhar-Hill 步枪（冲锋）", ShortName="Farquhar CF", ImageName="FarquharHill-11f5925b.png" },
        new() { Guid="11A0CC2F-9DE9-42FC-B528-91822B760819", Kind="医疗兵 主要武器", English="U_BSAHowellM1916", Chinese="Howell 自动步枪（原厂）", ShortName="Howell YC", ImageName="BSA_Howell-c3f2e18b.png" },
        new() { Guid="8DFC892E-00AE-47EC-A1D3-B866D40EE587", Kind="医疗兵 主要武器", English="U_BSAHowellM1916_Wep_Scope", Chinese="Howell 自动步枪（狙击手）", ShortName="Howell JJS", ImageName="BSA_Howell-c3f2e18b.png" },
        new() { Guid="4CFA2055-EB98-48E6-9BD9-70AAE7AF04AE", Kind="医疗兵 主要武器", English="U_FedorovDegtyarev", Chinese="费德洛夫 Degtyarev", ShortName="Fedorov SL", ImageName="FederovDegtyarev-ed497b9d.png" },

        // 医疗兵 配枪
        new() { Guid="447B3866-1241-42D7-8AB2-384727CFE624", Kind="医疗兵 配枪", English="U_WebFosAutoRev_455Webley", Chinese="自动左轮手枪", ShortName="Auto Rev", ImageName="WebleyFosberyAutoRevolver-a57ea28c.png" },
        new() { Guid="169D5DA6-8DB5-48B3-8101-DB208C4BB4DD", Kind="医疗兵 配枪", English="U_MauserC96", Chinese="C96", ShortName="C96", ImageName="MauserC96-52835b08.png" },
        new() { Guid="8373B804-511A-AB86-256D-9CE36CE25BA5", Kind="医疗兵 配枪", English="U_Mauser1914", Chinese="Taschenpistole M1914", ShortName="M1914", ImageName="Mauser1914-53a1954e.png" },

        // 医疗兵 配备一二
        new() { Guid="EBA4454E-EEB6-4AF1-9286-BD841E297ED4", Kind="医疗兵 配备一二", English="U_Syringe", Chinese="医疗用针筒", ShortName="Syringe", ImageName="GadgetSyringe-e6c764c2.png" },
        new() { Guid="670F817E-89A6-4048-B8B2-D9997DD97982", Kind="医疗兵 配备一二", English="U_MedicBag", Chinese="医护箱", ShortName="MedicBag", ImageName="GadgetMedicBag-159f240b.png" },
        new() { Guid="9BCDB1F5-5E1C-4C3E-824C-8C05CC0CE21A", Kind="医疗兵 配备一二", English="U_Bandages", Chinese="绷带包", ShortName="Bandages", ImageName="GadgetBandages-1d1fc900.png" },
        new() { Guid="F34B3039-7B3A-0272-14E7-628980A60F06", Kind="医疗兵 配备一二", English="_RGL_Frag", Chinese="步枪手榴弹（破片）", ShortName="RGL Frag", ImageName="MedicRifleLauncher_B-a712e224.png" },
        new() { Guid="03FDF635-8E98-4F74-A176-DB4960304DF5", Kind="医疗兵 配备一二", English="_RGL_Smoke", Chinese="步枪手榴弹（烟雾）", ShortName="RGL Smoke", ImageName="MedicRifleLauncher_A-438b725e.png" },
        new() { Guid="165ED044-C2C5-43A1-BE04-8618FA5072D4", Kind="医疗兵 配备一二", English="_RGL_HE", Chinese="步枪手榴弹（高爆）", ShortName="RGL HE", ImageName="MedicRifleLauncher_B-a712e224.png" },

        ////////////////////////////////// 支援兵 Support //////////////////////////////////

        // 支援兵 主要武器
        new() { Guid="B524273C-77FD-433E-8A40-270C00A4AE67", Kind="支援兵 主要武器", English="U_LewisMG_Wep_Suppression", Chinese="路易士机枪（压制）", ShortName="LewisMG YZ", ImageName="LewisLMG-832c29e8.png" },
        new() { Guid="CCE43311-3362-4D84-91D0-6A3D83B9BA17", Kind="支援兵 主要武器", English="U_LewisMG_Wep_Range", Chinese="路易士机枪（瞄准镜）", ShortName="LewisMG MZJ", ImageName="LewisLMG-832c29e8.png" },
        new() { Guid="B79B965E-E080-475D-A1CC-2432DE5F3BF5", Kind="支援兵 主要武器", English="U_LewisMG", Chinese="路易士机枪（轻量化）", ShortName="LewisMG QLH", ImageName="LewisLMG-832c29e8.png" },
        new() { Guid="465A4240-78EA-4648-868F-40EA06D5DC06", Kind="支援兵 主要武器", English="U_HotchkissM1909_Wep_Stability", Chinese="M1909 贝内特·梅西耶机枪（冲锋）", ShortName="M1909 CF", ImageName="HotchkissLMG-06defda3.png" },
        new() { Guid="02721F8C-6901-4389-B56A-89C3AC93C889", Kind="支援兵 主要武器", English="U_HotchkissM1909_Wep_Range", Chinese="M1909 贝内特·梅西耶机枪（瞄准镜）", ShortName="M1909 MZJ", ImageName="HotchkissLMG-06defda3.png" },
        new() { Guid="94286083-BE6A-46C0-AFAF-011635458AAA", Kind="支援兵 主要武器", English="U_HotchkissM1909_Wep_Bipod", Chinese="M1909 贝内特·梅西耶机枪（望远瞄具）", ShortName="M1909 WYMJ", ImageName="HotchkissLMG-06defda3.png" },
        new() { Guid="75DEC4E1-9A85-43A3-BBDE-9908F7A65D23", Kind="支援兵 主要武器", English="U_MadsenMG_Wep_Trench", Chinese="麦德森机枪（壕沟战）", ShortName="MadsenMG HGZ", ImageName="MadsenMG-51e41523.png" },
        new() { Guid="6E9863F2-2A32-4A0A-8F6C-BBC668044B15", Kind="支援兵 主要武器", English="U_MadsenMG_Wep_Stability", Chinese="麦德森机枪（冲锋）", ShortName="MadsenMG CF", ImageName="MadsenMG-51e41523.png" },
        new() { Guid="E2812647-A994-413B-B24F-24CAF2578551", Kind="支援兵 主要武器", English="U_MadsenMG", Chinese="麦德森机枪（轻量化）", ShortName="MadsenMG QLH", ImageName="MadsenMG-51e41523.png" },
        new() { Guid="2F0B54CD-CA30-4E9C-9384-5E967C478845", Kind="支援兵 主要武器", English="U_Bergmann1915MG_Wep_Suppression", Chinese="MG15 n.A.（压制）", ShortName="MG15 YZ", ImageName="Bergmann1915MG-891af31f.png" },
        new() { Guid="FFD12D82-9187-4F1A-823F-0F61E766EC98", Kind="支援兵 主要武器", English="U_Bergmann1915MG_Wep_Stability", Chinese="MG15 n.A.（冲锋）", ShortName="MG15 CF", ImageName="Bergmann1915MG-891af31f.png" },
        new() { Guid="64BE05D1-CE33-4DE5-9458-AB083C776635", Kind="支援兵 主要武器", English="U_Bergmann1915MG", Chinese="MG15 n.A.（轻量化）", ShortName="MG15 QLH", ImageName="Bergmann1915MG-891af31f.png" },
        new() { Guid="3231A399-B1DB-4D04-B286-1338092424B9", Kind="支援兵 主要武器", English="U_BARM1918_Wep_Trench", Chinese="M1918 白朗宁自动步枪（壕沟战）", ShortName="M1918 HGZ", ImageName="Barm1918-3c14511c.png" },
        new() { Guid="7D987B4E-A08C-41AD-A68B-245FBB5B10EF", Kind="支援兵 主要武器", English="U_BARM1918_Wep_Stability", Chinese="M1918 白朗宁自动步枪（冲锋）", ShortName="M1918 CF", ImageName="Barm1918-3c14511c.png" },
        new() { Guid="2D800408-99C2-4A84-9B8E-C713F4B6C450", Kind="支援兵 主要武器", English="U_BARM1918_Wep_Bipod", Chinese="M1918 白朗宁自动步枪（望远瞄具）", ShortName="M1918 WYMJ", ImageName="Barm1918-3c14511c.png" },
        new() { Guid="AB16FE32-BC40-4AB0-9F8C-07AADBBC1E4E", Kind="支援兵 主要武器", English="U_BARM1918A2", Chinese="M1918A2 白朗宁自动步枪", ShortName="M1918A2", ImageName="BARM1918A2-48c755b2.png" },
        new() { Guid="5C2C5A64-6227-4FA3-A382-E9DD68C66DAD", Kind="支援兵 主要武器", English="U_HuotAutoRifle", Chinese="Huot 自动步枪（轻量化）", ShortName="Huot QLH", ImageName="HuotAutoRifle-4ab70c1a.png" },
        new() { Guid="EE0A0210-4B5F-48DC-A02F-5879C24B1580", Kind="支援兵 主要武器", English="U_HuotAutoRifle_Wep_Range", Chinese="Huot 自动步枪（瞄准镜）", ShortName="Huot HGZ", ImageName="HuotAutoRifle-4ab70c1a.png" },
        new() { Guid="20BB8B94-1A01-4D8E-A2C7-7D19CE440802", Kind="支援兵 主要武器", English="U_Chauchat", Chinese="绍沙轻机枪（轻量化）", ShortName="Chauchat QLH", ImageName="Chauchat-787ad478.png" },
        new() { Guid="2C12E5FE-909A-4F0C-99FD-B23FBD1A6B4C", Kind="支援兵 主要武器", English="U_Chauchat_Wep_Bipod", Chinese="绍沙轻机枪（望远瞄具）", ShortName="Chauchat WYMJ", ImageName="Chauchat-787ad478.png" },
        new() { Guid="37207FD2-BD0C-460A-A065-6D8A5DEE2334", Kind="支援兵 主要武器", English="U_ParabellumLMG", Chinese="Parabellum MG14/17（轻量化）", ShortName="MG1417 QLH", ImageName="ParabellumMG1417-09dccd5b.png" },
        new() { Guid="95BDD2DE-CF36-45E1-B2F6-1DC5B8F8E632", Kind="支援兵 主要武器", English="U_ParabellumLMG_Wep_Suppression", Chinese="Parabellum MG14/17（压制）", ShortName="MG1417 YZ", ImageName="ParabellumMG1417-09dccd5b.png" },
        new() { Guid="406A7149-CFBC-4CD4-8ED7-B388AB1B5501", Kind="支援兵 主要武器", English="U_PerinoM1908", Chinese="Perino Model 1908（轻量化）", ShortName="M1908 QLH", ImageName="Perino1908-e97144b1.png" },
        new() { Guid="1B3EA625-4AFD-465D-AC16-16356B26BB82", Kind="支援兵 主要武器", English="U_PerinoM1908_Wep_Defensive", Chinese="Perino Model 1908（防御）", ShortName="M1908 FY", ImageName="Perino1908-e97144b1.png" },
        new() { Guid="BE397913-E33F-40B2-87C4-F7B92426AAA1", Kind="支援兵 主要武器", English="U_BrowningM1917", Chinese="M1917 机枪（轻量化）", ShortName="M1917 QLH", ImageName="Browning1917-61290bc9.png" },
        new() { Guid="96B134CC-5EDA-436A-9913-5ED429C696DD", Kind="支援兵 主要武器", English="U_BrowningM1917_Wep_Suppression", Chinese="M1917 机枪（望远瞄具）", ShortName="M1917 WYMJ", ImageName="Browning1917-61290bc9.png" },
        new() { Guid="57D820BF-38CC-4F62-8069-617E063971A0", Kind="支援兵 主要武器", English="U_MG0818", Chinese="轻机枪 08/18（轻量化）", ShortName="MG0818 QLH", ImageName="LMG_08-18-743c1aa8.png" },
        new() { Guid="16DF4163-78E0-4926-929A-E6052E04BE7F", Kind="支援兵 主要武器", English="U_MG0818_Wep_Defensive", Chinese="轻机枪 08/18（压制）", ShortName="MG0818 YZ", ImageName="LMG_08-18-743c1aa8.png" },
        new() { Guid="6C8284DF-9CEC-4391-9E1B-0E355C2D1310", Kind="支援兵 主要武器", English="U_WinchesterBurton_Wep_Trench", Chinese="波顿 LMR（战壕）", ShortName="Burton LMR ZH", ImageName="WinchesterBurton-ce3988cc.png" },
        new() { Guid="708392C1-38F7-4CFA-81E3-04FC90434021", Kind="支援兵 主要武器", English="U_WinchesterBurton_Wep_Optical", Chinese="波顿 LMR（瞄准镜）", ShortName="Burton LMR HZJ", ImageName="WinchesterBurton-ce3988cc.png" },
        new() { Guid="53B264D8-1E4D-42E9-AA31-401D55BA2F39", Kind="支援兵 主要武器", English="U_MauserC96AutoPistol", Chinese="C96（卡宾枪）", ShortName="C96 KBQ", ImageName="MauserC96CCarbine-741ab77d.png" },
        new() { Guid="0CC870E0-7AAE-44FE-B9D8-5D90706AF38B", Kind="支援兵 主要武器", English="U_LugerArtillery", Chinese="P08 Artillerie", ShortName="P08 Artillerie", ImageName="LugerArtillery-1fbfb83c.png" },
        new() { Guid="6CB23E70-F191-4043-951A-B43D6D2CF4A2", Kind="支援兵 主要武器", English="U_PieperCarbine", Chinese="皮珀 M1893", ShortName="M1893", ImageName="PieperCarbine-31e63cfb.png" },
        new() { Guid="3DC12572-2D2F-4439-95CA-8DFB80BA17F5", Kind="支援兵 主要武器", English="U_M1911_Stock", Chinese="M1911（加长）", ShortName="M1911 JC", ImageName="M1911ExtendedMag-eb019f60.png" },
        new() { Guid="2B421852-CFF9-41FF-B385-34580D5A9BF0", Kind="支援兵 主要武器", English="U_FN1903stock", Chinese="Mle 1903（加长）", ShortName="Mle 1903 JC", ImageName="FN1903stock-d8904447.png" },
        new() { Guid="EBE043CB-8D37-4807-9260-E2DD7EFC4BD2", Kind="支援兵 主要武器", English="U_C93Carbine", Chinese="C93（卡宾枪）", ShortName="C93 KBQ", ImageName="C93CarbineSup-120665d1.png" },

        // 支援兵 配枪
        new() { Guid="333D0B8C-404B-4B99-9588-B01736E0B742", Kind="支援兵 配枪", English="U_SteyrM1912", Chinese="Repetierpistole M1912", ShortName="M1912", ImageName="SteyrM1912-a49c97dd.png" },
        new() { Guid="B8EA5E4D-5B6A-9958-473F-20E8B2088CFD", Kind="支援兵 配枪", English="U_Bulldog", Chinese="斗牛犬左轮手枪", ShortName="Bulldog", ImageName="Bulldog-d95cfd90.png" },
        new() { Guid="101FAD96-0E8B-4AB2-9299-299A15CB5BF1", Kind="支援兵 配枪", English="U_BerettaM1915", Chinese="Modello 1915", ShortName="Modello 1915", ImageName="Beretta1915-e2c3c8d8.png" },
        new() { Guid="CF71A87B-2BD4-4AF8-AE80-D3B9F6F5CEDE", Kind="支援兵 配枪", English="U_M1911_A1", Chinese="M1911A1", ShortName="M1911A1", ImageName="Colt1911-ed324bf1.png" },

        // 支援兵 配备一二
        new() { Guid="2B0EC5C1-81A5-424A-A181-29B1E9920DDA", Kind="支援兵 配备一二", English="U_AmmoCrate", Chinese="弹药箱", ShortName="Ammo Crate", ImageName="GadgetAmmoCrate-61f48e78.png" },
        new() { Guid="52B19C38-72C0-4E0F-B051-EF11103F6220", Kind="支援兵 配备一二", English="U_AmmoPouch", Chinese="弹药包", ShortName="Ammo Pouch", ImageName="GadgetSmallAmmoPack-5837fde5.png" },
        new() { Guid="C71A02C3-608E-42AA-9179-A4324A4D4539", Kind="支援兵 配备一二", English="U_Mortar", Chinese="迫击炮（空爆）", ShortName="Mortar KB", ImageName="MortarAirburst-77c9647f.png" },
        new() { Guid="8BD0FABD-DCCE-4031-8156-B77866FCE1A0", Kind="支援兵 配备一二", English="U_Mortar_HE", Chinese="迫击炮（高爆）", ShortName="Mortar GB", ImageName="GadgetMortar-84e30045.png" },
        new() { Guid="F59AA727-6618-4C1D-A5E2-007044CA3B89", Kind="支援兵 配备一二", English="U_Wrench", Chinese="维修工具", ShortName="Wrench", ImageName="GadgetWrench-07e2c76d.png" },
        new() { Guid="95A5E9D8-E949-46C2-B5CA-36B3CA4C2E9D", Kind="支援兵 配备一二", English="U_LimpetMine", Chinese="磁吸地雷", ShortName="Limpet Mine", ImageName="GadgetLimpetMine-a6d78b8f.png" },
        new() { Guid="02D4481F-FBC3-4C57-AAAC-1B37DC92751E", Kind="支援兵 配备一二", English="U_Crossbow", Chinese="十字弓发射器（破片）", ShortName="Crossbow PP", ImageName="crossbow-5f3dc5e6.png" },
        new() { Guid="60D24A79-BFD6-4C8F-B54F-D1AA6D2620DE", Kind="支援兵 配备一二", English="U_Crossbow_HE", Chinese="十字弓发射器（高爆）", ShortName="Crossbow GB", ImageName="crossbow-5f3dc5e6.png" },

        ////////////////////////////////// 侦察兵 Scout   //////////////////////////////////

        // 侦察兵 主要武器
        new() { Guid="11AAA000-BEA2-44E4-A463-11CE25CA4E93", Kind="侦察兵 主要武器", English="U_WinchesterM1895_Wep_Trench", Chinese="Russian 1895（壕沟战）", ShortName="1895 HGZ", ImageName="Winchester1895-69d56c0b.png" },
        new() { Guid="5BD7640B-2308-4CB9-98EB-26E4AB5AB1C9", Kind="侦察兵 主要武器", English="U_WinchesterM1895_Wep_Long", Chinese="Russian 1895（狙击手）", ShortName="1895 JJS", ImageName="Winchester1895-69d56c0b.png" },
        new() { Guid="4A960C79-5265-4559-B1D2-90E1B5BE7238", Kind="侦察兵 主要武器", English="U_WinchesterM1895", Chinese="Russian 1895（步兵）", ShortName="1895 BB", ImageName="Winchester1895-69d56c0b.png" },
        new() { Guid="DA44F656-997F-4DD8-B3A2-34B9E057BE19", Kind="侦察兵 主要武器", English="U_Gewehr98_Wep_Scope", Chinese="Gewehr 98（神射手）", ShortName="G98 SSS", ImageName="MauserGewehr98-f159616f.png" },
        new() { Guid="2E2F512C-D9DC-470E-86E0-8B5F827FEA8A", Kind="侦察兵 主要武器", English="U_Gewehr98_Wep_LongRange", Chinese="Gewehr 98（狙击手）", ShortName="G98 JJS", ImageName="MauserGewehr98-f159616f.png" },
        new() { Guid="2EEF7FFC-A1A4-4143-A0DF-3F41EF611433", Kind="侦察兵 主要武器", English="U_Gewehr98", Chinese="Gewehr 98（步兵）", ShortName="G98 BB", ImageName="MauserGewehr98-f159616f.png" },
        new() { Guid="F59A978F-54BB-43F9-8497-47EC8D907EA6", Kind="侦察兵 主要武器", English="U_LeeEnfieldSMLE_Wep_Scope", Chinese="SMLE MKIII（神射手）", ShortName="MKIII SSS", ImageName="LeeEnfield-52626131.png" },
        new() { Guid="DB650ACE-7B44-4FA1-A146-EAE44E94C68C", Kind="侦察兵 主要武器", English="U_LeeEnfieldSMLE_Wep_Med", Chinese="SMLE MKIII（卡宾枪）", ShortName="MKIII KBQ", ImageName="LeeEnfield-52626131.png" },
        new() { Guid="CD35EDD7-6F6E-4B72-ACC7-37CD0E4D060A", Kind="侦察兵 主要武器", English="U_LeeEnfieldSMLE", Chinese="SMLE MKIII（步兵）", ShortName="MKIII BB", ImageName="LeeEnfield-52626131.png" },
        new() { Guid="7ED7AE0D-03C6-44D4-9072-261C6570B3BF", Kind="侦察兵 主要武器", English="U_SteyrManM1895_Wep_Scope", Chinese="Gewehr M.95（神射手）", ShortName="G95 SSS", ImageName="Mannlicher1895-7850a8ec.png" },
        new() { Guid="7668C6B5-D793-442A-8AFA-74E4CD158F33", Kind="侦察兵 主要武器", English="U_SteyrManM1895_Wep_Med", Chinese="Gewehr M.95（卡宾枪）", ShortName="G95 KBQ", ImageName="Mannlicher1895-7850a8ec.png" },
        new() { Guid="E372F592-9278-4777-A9E3-C91B171FD1F7", Kind="侦察兵 主要武器", English="U_SteyrManM1895", Chinese="Gewehr M.95（步兵）", ShortName="G95 BB", ImageName="Mannlicher1895-7850a8ec.png" },
        new() { Guid="B0987D7E-F43D-4AA7-9A8E-A33EFA985864", Kind="侦察兵 主要武器", English="U_SpringfieldM1903_Wep_Scope", Chinese="M1903（神射手）", ShortName="M1903 SSS", ImageName="SpringfieldM1903-c8ae5988.png" },
        new() { Guid="BA5E14FF-D373-4927-9D0F-11CD9423AE4B", Kind="侦察兵 主要武器", English="U_SpringfieldM1903_Wep_LongRange", Chinese="M1903（狙击手）", ShortName="M1903 JJS", ImageName="SpringfieldM1903-c8ae5988.png" },
        new() { Guid="9984202B-FE89-447C-879B-25A2B797A176", Kind="侦察兵 主要武器", English="U_SpringfieldM1903_Wep_Pedersen", Chinese="M1903（实验）", ShortName="M1903 SY", ImageName="SpringfieldM1903-c8ae5988.png" },
        new() { Guid="43E292F0-511B-458B-852A-7EBDB20F6B27", Kind="侦察兵 主要武器", English="U_MartiniHenry", Chinese="马提尼·亨利步枪（步兵）", ShortName="MartiniHenry BB", ImageName="MartinHenry-c8477a11.png" },
        new() { Guid="0440A003-1E71-47A2-98A9-73EC23D83CB4", Kind="侦察兵 主要武器", English="U_MartiniHenry_Wep_LongRange", Chinese="马提尼·亨利步枪（狙击手）", ShortName="MartiniHenry JJS", ImageName="MartinHenry-c8477a11.png" },
        new() { Guid="1AC12662-F06E-4562-80A3-FFD598CEB7EB", Kind="侦察兵 主要武器", English="U_LeeEnfieldSMLE_Wep_Preorder", Chinese="阿拉伯的劳伦斯的 SMLE", ShortName="SMLE LLS", ImageName="LeeEnfield-52626131.png" },
        new() { Guid="85EFAE4D-6C60-4DA0-8F38-0548E1FB193F", Kind="侦察兵 主要武器", English="U_Lebel1886_Wep_LongRange", Chinese="勒贝尔 M1886（狙击手）", ShortName="M1886 JJS", ImageName="Lebel1886-31bf07f8.png" },
        new() { Guid="59D35CF4-3530-4B8C-9519-A78E9577BA1A", Kind="侦察兵 主要武器", English="U_Lebel1886", Chinese="勒贝尔 M1886（步兵）", ShortName="M1886 BB", ImageName="Lebel1886-31bf07f8.png" },
        new() { Guid="FA55E980-2D48-4CFC-8700-1E0533C9CB4A", Kind="侦察兵 主要武器", English="U_MosinNagant1891", Chinese="莫辛-纳甘 M91（步兵）", ShortName="M91 BB", ImageName="MosinNagantM1891-fac2efac.png" },
        new() { Guid="9A1C2640-9684-414E-9D05-94F5A9858296", Kind="侦察兵 主要武器", English="U_MosinNagant1891_Wep_Scope", Chinese="莫辛-纳甘 M91（神射手）", ShortName="M91 SSS", ImageName="MosinNagantM1891-fac2efac.png" },
        new() { Guid="4A392B4B-97FA-4672-B5D8-C4085A87CB39", Kind="侦察兵 主要武器", English="U_MosinNagantM38", Chinese="莫辛-纳甘 M38 卡宾枪", ShortName="M38 KBQ", ImageName="MosinNagantM38-dd529587.png" },
        new() { Guid="4B831597-5062-461E-9CC9-9611BD1B50E3", Kind="侦察兵 主要武器", English="U_VetterliVitaliM1870", Chinese="Vetterli-Vitali M1870/87（步兵）", ShortName="M1870 BB", ImageName="Vetterli-VitaliM1870-87-faadf520.png" },
        new() { Guid="B6B5C8CB-0C40-4522-8907-4FCE5B243C83", Kind="侦察兵 主要武器", English="U_VetterliVitaliM1870_Wep_Med", Chinese="Vetterli-Vitali M1870/87（卡宾枪）", ShortName="M1870 KBQ", ImageName="Vetterli-VitaliM1870-87-faadf520.png" },
        new() { Guid="A3A708E8-6719-4178-9958-36814E906FD4", Kind="侦察兵 主要武器", English="U_Type38Arisaka", Chinese="三八式步枪（步兵）", ShortName="Type38 BB", ImageName="Type38Arisaka-a1c192e3.png" },
        new() { Guid="BB20B711-EF98-4708-998A-D78780B8B8C4", Kind="侦察兵 主要武器", English="U_Type38Arisaka_Wep_Scope", Chinese="三八式步枪（巡逻）", ShortName="Type38 XL", ImageName="Type38Arisaka-a1c192e3.png" },
        new() { Guid="D0DBCD64-BFAE-4B96-867E-C493641C269B", Kind="侦察兵 主要武器", English="U_CarcanoCarbine", Chinese="卡尔卡诺 M91 卡宾枪", ShortName="M91 KBQ", ImageName="M1891CarcanoCarbine-cc7d34a1.png" },
        new() { Guid="4E317627-F7F8-4014-BB22-B0ABEB7E9141", Kind="侦察兵 主要武器", English="U_CarcanoCarbine_Wep_Scope", Chinese="卡尔卡诺 M91 卡宾枪（巡逻）", ShortName="M91 KBQ XL", ImageName="M1891CarcanoCarbine-cc7d34a1.png" },
        new() { Guid="8FAB67E1-A8ED-4EC0-8135-DB2BAA832890", Kind="侦察兵 主要武器", English="U_RossMkIII", Chinese="罗斯 MKIII（步兵）", ShortName="RossMkIII BB", ImageName="Ross_Mk3-f8900bf5.png" },
        new() { Guid="168D4F4B-AD76-40D3-AD86-EB52890872D8", Kind="侦察兵 主要武器", English="U_RossMkIII_Wep_Scope", Chinese="罗斯 MKIII（神射手）", ShortName="RossMkIII SSS", ImageName="Ross_Mk3-f8900bf5.png" },
        new() { Guid="D8F58A20-88D8-4C25-B395-385641324ACF", Kind="侦察兵 主要武器", English="U_Enfield1917", Chinese="M1917 Enfield（步兵）", ShortName="M1917 BB", ImageName="Enfield1917-d33fc14d.png" },
        new() { Guid="374F5969-7A06-4188-BA76-266F91304FE4", Kind="侦察兵 主要武器", English="U_Enfield1917_Wep_LongRange", Chinese="M1917 Enfield（消音器）", ShortName="M1917 XYQ", ImageName="Enfield1917-d33fc14d.png" },

        // 侦察兵 配枪
        new() { Guid="E5A72AA0-02C9-40B8-A74D-D60C921D1288", Kind="侦察兵 配枪", English="U_MarsAutoPistol", Chinese="Mars 自动手枪", ShortName="MarsAutoPistol", ImageName="MarsAutoPistol-7f2606e9.png" },
        new() { Guid="F08BC756-2600-4834-BDBA-4E53C4A24E1D", Kind="侦察兵 配枪", English="U_Bodeo1889", Chinese="Bodeo 1889", ShortName="Bodeo 1889", ImageName="Bodeo1889-a62282b6.png" },
        new() { Guid="FAE1EA24-DFBE-3E0A-E525-BC20340FE196", Kind="侦察兵 配枪", English="U_FrommerStop", Chinese="费罗梅尔停止手枪", ShortName="Frommer Stop", ImageName="FrommerStopAuto-ea5b918e.png" },

        // 侦察兵 配备一二
        new() { Guid="2543311A-B9BC-4F72-8E71-C9D32DCA9CFC", Kind="侦察兵 配备一二", English="U_FlareGun", Chinese="信号枪（侦察）", ShortName="Flare Gun ZC", ImageName="GadgetWebleyScottFlaregun-4438a413.png" },
        new() { Guid="ADAD5F72-BD74-46EF-AB42-99F95D88DF8E", Kind="侦察兵 配备一二", English="U_FlareGun_Flash", Chinese="信号枪（闪光）", ShortName="Flare Gun SG", ImageName="GadgetWebleyScottFlaregunFlash-40b27cca.png" },
        new() { Guid="C43D1466-F9D1-474B-A737-3820B6989819", Kind="侦察兵 配备一二", English="U_TrPeriscope", Chinese="战壕潜望镜", ShortName="Tr Periscope", ImageName="GadgetTrenchPeriscope-d916e58e.png" },
        new() { Guid="370323AD-6AFD-4D44-899E-7FB8144E580F", Kind="侦察兵 配备一二", English="U_Shield", Chinese="狙击手护盾", ShortName="Shield", ImageName="GadgetShield-9a6f10a4.png" },
        new() { Guid="C85A5030-C6DA-4DEF-8BA5-3087A80DEC17", Kind="侦察兵 配备一二", English="U_HelmetDecoy", Chinese="狙击手诱饵", ShortName="Helmet Decoy", ImageName="GadgetHelmetDecoy-182ae8c4.png" },
        new() { Guid="EF1C7B9B-8912-4298-8FCB-29CC75DD0E7F", Kind="侦察兵 配备一二", English="U_TripWireBomb", Chinese="绊索炸弹（高爆）", ShortName="Trip Wire Bomb", ImageName="GadgetTripWireGrenade-1618bbc3.png" },
        new() { Guid="033299D1-A8E6-4A5A-8932-6F2091745A9D", Kind="侦察兵 配备一二", English="U_TripWireGas", Chinese="绊索炸弹（毒气）", ShortName="Trip Wire Gas", ImageName="GadgetTripWireBombGas-f1eabac0.png" },
        new() { Guid="9CF9EA1C-39A1-4365-85A1-3645B9621901", Kind="侦察兵 配备一二", English="U_TripWireBurn", Chinese="绊索炸弹（燃烧）", ShortName="Trip Wire Burn", ImageName="TripWireBombINC-6a9a41fb.png" },
        new() { Guid="2D64B139-27C8-4EDB-AB14-734993A96008", Kind="侦察兵 配备一二", English="_KBullet", Chinese="K弹", ShortName="K Bullet", ImageName="GadgetKBullets-0ec1f92a.png" },

        /////////////////////////////////////////////////////////////////////////////

        // 精英兵
        new() { Guid="0B575357-B536-45FF-BC1B-386560AE2163", Kind="精英兵", English="U_MaximMG0815", Chinese="哨兵 MG 08/15", ShortName="Maxim MG0815", ImageName="Maxim0815-0879ffaa.png" },
        new() { Guid="BCF1DDDF-C812-43E6-9F5A-F08109BAB746", Kind="精英兵", English="U_VillarPerosa", Chinese="哨兵 维拉·佩罗萨冲锋枪", ShortName="Villar Perosa", ImageName="VillarPerosa-4ba7d141.png" },
        new() { Guid="D4A1023A-6C3B-48DF-9515-C35A9463794D", Kind="精英兵", English="U_FlameThrower", Chinese="喷火兵 Wex", ShortName="Wex", ImageName="WEXFlammenwerfer-13f2b3af.png" },
        new() { Guid="8219207A-41E6-4ED2-A3E8-9690752EC40C", Kind="精英兵", English="U_Incendiary_Hero", Chinese="燃烧手榴弹", ShortName="Incendiary Hero", ImageName="GadgetIncindiary-68d49a3a.png" },
        new() { Guid="8A849EDD-AE9F-4F9D-B872-7728067E4E9F", Kind="精英兵", English="U_RoyalClub", Chinese="战壕奇兵 奇兵棒", ShortName="Royal Club", ImageName="Steelclub-83b053cf.png" },
        new() { Guid="1B74E3E0-2484-3BF0-AF8F-25BFA008B6F0", Kind="精英兵", English="U_MartiniGrenadeLauncher", Chinese="入侵者 马提尼·亨利步枪榴弹发射器", ShortName="Martini GL", ImageName="MartiniHenryGrenadeLauncher-65e27bf0.png" },
        new() { Guid="7085A5B9-6A77-4766-83CD-3666DA3EDF28", Kind="精英兵", English="U_SawnOffShotgun_FK", Chinese="短管霰弹枪", ShortName="SawnOffShotgun", ImageName="SawedOfShotgun-d31e0dd8.png" },
        new() { Guid="9D1BEE08-C101-4FF3-8ECA-244240171801", Kind="精英兵", English="U_FlareGun_Elite", Chinese="信号枪 — 信号", ShortName="FlareGun Elite", ImageName="GadgetWebleyScottFlaregunFlash-40b27cca.png" },
        new() { Guid="??????", Kind="精英兵", English="U_SpawnBeacon", Chinese="重生信标", ShortName="Spawn Beacon", ImageName="GadgetHeliograph-66004cd6.png" },
        new() { Guid="A9DBBCBD-E028-4EE9-8123-252B983D8CD6", Kind="精英兵", English="U_TankGewehr", Chinese="坦克猎手 Tankgewehr M1918", ShortName="Tank Gewehr", ImageName="MauserTankgewehr1918-aedf4c56.png" },
        new() { Guid="C43D1466-F9D1-474B-A737-3820B6989819", Kind="精英兵", English="U_TrPeriscope_Elite", Chinese="战壕潜望镜", ShortName="Tr Periscope", ImageName="GadgetTrenchPeriscope-d916e58e.png" },
        new() { Guid="72CCBF3E-C0FE-4657-A1A7-EACDB2D11985", Kind="精英兵", English="U_ATGrenade_VhKit", Chinese="反坦克手榴弹", ShortName="AT Grenade", ImageName="GadgetATGrenade-4b135d46.png" },

        ///////////////////////////////////////////////////////////////////////////////////

        // 载具
        new() { Guid="4723A26F-98AE-55BA-7B3F-3AE7E0E3B0C7", Kind="坦克", English="ID_P_VNAME_MARKV", Chinese="巡航坦克 Mark V 巡航坦克", ShortName="Mark V", ImageName="GBRMarkV-bf3b1d1a.png" },
        new() { Guid="4723A26F-98AE-55BA-7B3F-3AE7E0E3B0C7", Kind="巡航坦克1", English="U_GBR_MarkV_Package_Mortar", Chinese="迫击炮巡航坦克", ShortName="Mark V PJP", ImageName="GBRMarkV-bf3b1d1a.png" },
        new() { Guid="4723A26F-98AE-55BA-7B3F-3AE7E0E3B0C7", Kind="巡航坦克2", English="U_GBR_MarkV_Package_AntiTank", Chinese="坦克猎手巡航坦克", ShortName="Mark V TKLS", ImageName="GBRMarkV-bf3b1d1a.png" },
        new() { Guid="4723A26F-98AE-55BA-7B3F-3AE7E0E3B0C7", Kind="巡航坦克3", English="U_GBR_MarkV_Package_SquadSupport", Chinese="小队支援巡航坦克", ShortName="Mark V XDZY", ImageName="GBRMarkV-bf3b1d1a.png" },

        new() { Guid="4AA28E71-6FDA-A50B-80A8-B52D070FF884", Kind="坦克", English="ID_P_VNAME_A7V", Chinese="重型坦克 AV7 重型坦克", ShortName="AV7", ImageName="GERA7V-bfc09237.png" },
        new() { Guid="4AA28E71-6FDA-A50B-80A8-B52D070FF884", Kind="重型坦克1", English="U_GER_A7V_Package_Assault", Chinese="重型突击坦克", ShortName="AV7 TJ", ImageName="GERA7V-bfc09237.png" },
        new() { Guid="4AA28E71-6FDA-A50B-80A8-B52D070FF884", Kind="重型坦克2", English="U_GER_A7V_Package_Breakthrough", Chinese="重型突破坦克", ShortName="AV7 TP", ImageName="GERA7V-bfc09237.png" },
        new() { Guid="4AA28E71-6FDA-A50B-80A8-B52D070FF884", Kind="重型坦克3", English="U_GER_A7V_Package_Flamethrower", Chinese="重型火焰喷射器坦克", ShortName="AV7 HYPSQ", ImageName="GERA7V-bfc09237.png" },

        new() { Guid="A79071D2-5C4F-0BA8-0ECC-FCB1376E2FBA", Kind="坦克", English="ID_P_VNAME_FT17", Chinese="轻型坦克 FT-17 轻型坦克", ShortName="FT-17", ImageName="FRARenaultFt-17-aea9e5e7.png" },
        new() { Guid="A79071D2-5C4F-0BA8-0ECC-FCB1376E2FBA", Kind="轻型坦克1", English="U_FRA_FT_Package_37mm", Chinese="轻型近距离支援坦克", ShortName="FT-17 JJLZY", ImageName="FRARenaultFt-17-aea9e5e7.png" },
        new() { Guid="A79071D2-5C4F-0BA8-0ECC-FCB1376E2FBA", Kind="轻型坦克2", English="U_FRA_FT_Package_20mm", Chinese="轻型侧翼攻击坦克", ShortName="FT-17 CYGJ", ImageName="FRARenaultFt-17-aea9e5e7.png" },
        new() { Guid="A79071D2-5C4F-0BA8-0ECC-FCB1376E2FBA", Kind="轻型坦克3", English="U_FRA_FT_Package_75mm", Chinese="轻型榴弹炮坦克", ShortName="FT-17 LDP", ImageName="FRARenaultFt-17-aea9e5e7.png" },

        new() { Guid="A92386FB-7D4B-0E8A-6F2B-CC63FC2A8D78", Kind="坦克", English="ID_P_VNAME_ARTILLERYTRUCK", Chinese="装甲车 火炮装甲车", ShortName="ARTILLERYTRUCK", ImageName="GBRPierceArrowAALorry-6e6d8d9f.png" },
        new() { Guid="A92386FB-7D4B-0E8A-6F2B-CC63FC2A8D78", Kind="火炮装甲车1", English="U_GBR_PierceArrow_Package_Artillery", Chinese="火炮装甲车", ShortName="ATruck HP", ImageName="GBRPierceArrowAALorry-6e6d8d9f.png" },
        new() { Guid="A92386FB-7D4B-0E8A-6F2B-CC63FC2A8D78", Kind="火炮装甲车2", English="U_GBR_PierceArrow_Package_AntiAircraft", Chinese="防空装甲车", ShortName="ATruck AA", ImageName="GBRPierceArrowAALorry-6e6d8d9f.png" },
        new() { Guid="A92386FB-7D4B-0E8A-6F2B-CC63FC2A8D78", Kind="火炮装甲车3", English="U_GBR_PierceArrow_Package_Mortar", Chinese="迫击炮装甲车", ShortName="ATruck Mortar", ImageName="GBRPierceArrowAALorry-6e6d8d9f.png" },

        new() { Guid="12F1002B-97FA-490B-822F-E621C6827BFB", Kind="坦克", English="ID_P_VNAME_STCHAMOND", Chinese="攻击坦克 圣沙蒙", ShortName="STCHAMOND", ImageName="FRAStChamond-3123e0cd.png" },
        new() { Guid="12F1002B-97FA-490B-822F-E621C6827BFB", Kind="攻击坦克1", English="U_FRA_StChamond_Package_Assault", Chinese="战地攻击坦克", ShortName="STCHAMOND ZD", ImageName="FRAStChamond-3123e0cd.png" },
        new() { Guid="12F1002B-97FA-490B-822F-E621C6827BFB", Kind="攻击坦克2", English="U_FRA_StChamond_Package_Gas", Chinese="毒气攻击坦克", ShortName="STCHAMOND DQ", ImageName="FRAStChamond-3123e0cd.png" },
        new() { Guid="12F1002B-97FA-490B-822F-E621C6827BFB", Kind="攻击坦克3", English="U_FRA_StChamond_Package_Standoff", Chinese="对峙攻击坦克", ShortName="STCHAMOND DZ", ImageName="FRAStChamond-3123e0cd.png" },

        new() { Guid="705E9B4E-5E97-FD3C-9979-A4F2D11AE06F", Kind="坦克", English="ID_P_VNAME_ASSAULTTRUCK", Chinese="突袭装甲车 朴帝洛夫·加福德", ShortName="ASSAULTTRUCK", ImageName="PutilovGarford-20a4fd91.png" },
        new() { Guid="705E9B4E-5E97-FD3C-9979-A4F2D11AE06F", Kind="突袭装甲车1", English="U_RU_PutilovGarford_Package_AssaultGun", Chinese="突袭装甲车", ShortName="ATTruck TX", ImageName="PutilovGarford-20a4fd91.png" },
        new() { Guid="705E9B4E-5E97-FD3C-9979-A4F2D11AE06F", Kind="突袭装甲车2", English="U_RU_PutilovGarford_Package_AntiVehicle", Chinese="反坦克装甲车", ShortName="ATTruck AT", ImageName="PutilovGarford-20a4fd91.png" },
        new() { Guid="705E9B4E-5E97-FD3C-9979-A4F2D11AE06F", Kind="突袭装甲车3", English="U_RU_PutilovGarford_Package_Recon", Chinese="侦察装甲车", ShortName="ATTruck ZC", ImageName="PutilovGarford-20a4fd91.png" },

        ////////////////////////////////

        new() { Guid="EB79DB6E-8A05-9618-3368-34DCBE3C3C17", Kind="飞机", English="ID_P_VNAME_HALBERSTADT", Chinese="攻击机 哈尔伯施塔特 CL.II 攻击机", ShortName="HALBERSTADT", ImageName="GERHalberstadtCLII-c1cb8257.png" },
        new() { Guid="33A894B8-BCE1-8689-3064-7308BBC781CC", Kind="飞机", English="ID_P_VNAME_BRISTOL", Chinese="攻击机 布里斯托 F2.B 攻击机", ShortName="BRISTOL", ImageName="GBRBristolF2B-141b8daa.png" },
        new() { Guid="189D43F5-E653-416B-B6D6-D0137C28375D", Kind="飞机", English="ID_P_VNAME_SALMSON", Chinese="攻击机 A.E.F 2-A2 攻击机", ShortName="SALMSON", ImageName="FRA_Salmson_2-05f47b5c.png" },
        new() { Guid="C3272C97-B92E-4E2A-B842-06EF06DC2CB0", Kind="飞机", English="ID_P_VNAME_RUMPLER", Chinese="攻击机 Rumpler C.I 攻击机", ShortName="RUMPLER", ImageName="AHU_Rumpler_CI-eb45a6be.png" },

        new() { Guid="??????", Kind="攻击机1", English="U_2Seater_Package_GroundSupport", Chinese="地面支援攻击机", ShortName="2Seater DMZY", ImageName="AHU_Rumpler_CI-eb45a6be.png" },
        new() { Guid="??????", Kind="攻击机2", English="U_2Seater_Package_TankHunter", Chinese="坦克猎手攻击机", ShortName="2Seater TKLS", ImageName="AHU_Rumpler_CI-eb45a6be.png" },
        new() { Guid="??????", Kind="攻击机3", English="U_2Seater_Package_AirshipBuster", Chinese="飞船毁灭者攻击机", ShortName="2Seater FCHMZ", ImageName="AHU_Rumpler_CI-eb45a6be.png" },

        new() { Guid="2B0D6EA6-8978-6400-7E85-C8ED33E3B6B3", Kind="飞机", English="ID_P_VNAME_GOTHA", Chinese="轰炸机 戈塔 G 轰炸机", ShortName="GOTHA", ImageName="GERGothaGIV-54bfb0bf.png" },
        new() { Guid="91ECED06-9066-470D-BFE0-A1122118A5B3", Kind="飞机", English="ID_P_VNAME_CAPRONI", Chinese="轰炸机 卡普罗尼 CA.5 轰炸机", ShortName="CAPRONI", ImageName="ITACaproniCa5-31fc77c8.png" },
        new() { Guid="DF87BA6E-961D-4F14-86B4-AE5F1326BA14", Kind="飞机", English="ID_P_VNAME_DH10", Chinese="轰炸机 Airco DH.10 轰 炸机", ShortName="DH10", ImageName="GBR_Airco_DH10-05e772e8.png" },
        new() { Guid="887AA8B4-878C-4943-B688-BAE3E9A5A4E7", Kind="飞机", English="ID_P_VNAME_HBG1", Chinese="轰炸机 汉莎·布兰登堡 G.I 轰炸机", ShortName="HBG1", ImageName="AHU_Hansa_Brandenburg_GI-042fc3dc.png" },

        new() { Guid="??????", Kind="轰炸机1", English="U_Bomber_Package_Barrage", Chinese="弹幕轰炸机", ShortName="Bomber DM", ImageName="AHU_Hansa_Brandenburg_GI-042fc3dc.png" },
        new() { Guid="??????", Kind="轰炸机2", English="U_Bomber_Package_Firestorm", Chinese="火焰风暴轰炸机", ShortName="Bomber YYFB", ImageName="AHU_Hansa_Brandenburg_GI-042fc3dc.png" },
        new() { Guid="??????", Kind="轰炸机3", English="U_Bomber_Package_Torpedo", Chinese="鱼雷轰炸机", ShortName="Bomber YL", ImageName="AHU_Hansa_Brandenburg_GI-042fc3dc.png" },

        new() { Guid="CB7D595C-0376-4C72-A8B8-1455965EA81E", Kind="飞机", English="ID_P_VNAME_SPAD", Chinese="战斗机 SPAD S XIII 战斗机", ShortName="SPAD S XIII", ImageName="FRA_SPAD_X_XIII-8f60a194.png" },
        new() { Guid="ADF5B89F-5854-43C4-BAD4-46C9D1C020F5", Kind="飞机", English="ID_P_VNAME_SOPWITH", Chinese="战斗机 索普维斯骆驼式战斗机", ShortName="SOPWITH", ImageName="GBRSopwithCamel-39d664a3.png" },
        new() { Guid="AD78AD89-1824-B113-75EC-CFD3180A367D", Kind="飞机", English="ID_P_VNAME_DR1", Chinese="战斗机 DR.1 战斗机", ShortName="DR1", ImageName="GERFokkerDR1-14f95745.png" },
        new() { Guid="6D6C110E-EBC9-42CC-BB7A-ACA156638D3C", Kind="飞机", English="ID_P_VNAME_ALBATROS", Chinese="战斗机 信天翁 D-III 战斗机", ShortName="ALBATROS", ImageName="GER_Albatros_DIII-5ca9e1d3.png" },

        new() { Guid="??????", Kind="战斗机1", English="U_Scout_Package_Dogfighter", Chinese="空战机", ShortName="Scout KZJ", ImageName="GER_Albatros_DIII-5ca9e1d3.png" },
        new() { Guid="??????", Kind="战斗机2", English="U_Scout_Package_BomberKiller", Chinese="轰炸机杀手", ShortName="Scout HZJSS", ImageName="GER_Albatros_DIII-5ca9e1d3.png" },
        new() { Guid="??????", Kind="战斗机3", English="U_Scout_Package_TrenchFighter", Chinese="战壕战斗机", ShortName="Scout ZHZDJ", ImageName="GER_Albatros_DIII-5ca9e1d3.png" },

        new() { Guid="E305E0C1-FED8-00FD-747A-C9282C51F524", Kind="飞机", English="ID_P_VNAME_ILYAMUROMETS", Chinese="重型轰炸机 伊利亚·穆罗梅茨", ShortName="ILYAMUROMETS", ImageName="IlyaMurometsHeavyBomber-74779164.png" },

        new() { Guid="??????", Kind="重型轰炸机1", English="U_HeavyBomber_Package_Strategic", Chinese="重型战略轰炸机", ShortName="HeavyBomber ZL", ImageName="IlyaMurometsHeavyBomber-74779164.png" },
        new() { Guid="??????", Kind="重型轰炸机2", English="U_HeavyBomber_Package_Demolition", Chinese="重型爆破轰炸机", ShortName="HeavyBomber BP", ImageName="IlyaMurometsHeavyBomber-74779164.png" },
        new() { Guid="??????", Kind="重型轰炸机3", English="U_HeavyBomber_Package_Support", Chinese=" 重型支援轰炸机", ShortName="HeavyBomber ZY", ImageName="IlyaMurometsHeavyBomber-74779164.png" },

        new() { Guid="4289E1A4-5EBE-7FA3-52D8-AFDB8ED374BA", Kind="飞船", English="ID_P_VNAME_ASTRATORRES", Chinese="飞船 C 级飞船", ShortName="ASTRATORRES", ImageName="AstraTorresAirship-e2148807.png" },

        new() { Guid="??????", Kind="飞船1", English="U_CoastalAirship_Package_Observation", Chinese="观察者", ShortName="Airship GCZ", ImageName="AstraTorresAirship-e2148807.png" },
        new() { Guid="??????", Kind="飞船2", English="U_CoastalAirship_Package_Raider", Chinese="掠夺者", ShortName="Airship NDZ", ImageName="AstraTorresAirship-e2148807.png" },
        
        ////////////////////////////////
        
        new() { Guid="67B44E81-D1DA-B485-D185-D6520CF59E4B", Kind="驱逐舰", English="ID_P_VNAME_HMS_LANCE", Chinese="驱逐舰 L 级驱逐舰", ShortName="HMS LANCE", ImageName="HMSLancerDestroyer-65317e44.png" },

        new() { Guid="??????", Kind="驱逐舰1", English="U_HMS_Lance_Package_Destroyer", Chinese="鱼雷艇驱逐舰", ShortName="HMS LANCE YL", ImageName="HMSLancerDestroyer-65317e44.png" },
        new() { Guid="??????", Kind="驱逐舰2", English="U_HMS_Lance_Package_Minelayer", Chinese="水雷布设艇", ShortName="HMS LANCE SL", ImageName="HMSLancerDestroyer-65317e44.png" },
        
        ////////////////////////////////
        
        new() { Guid="7CA00F5A-E5DE-3FD9-ECAD-7D4FC5C1AC80", Kind="骑兵", English="ID_P_VNAME_HORSE", Chinese="骑兵 战马", ShortName="HORSE", ImageName="Horse-c07830d0.png" },
        
        ////////////////////////////////

        new() { Guid="E76568C5-B222-4C49-B4E0-D517425596C6", Kind="驾驶员下车", English="U_WinchesterM1895_Horse", Chinese="Russian 1895（骑兵）", ShortName="M1895 Horse", ImageName="Winchester1895-69d56c0b.png" },
        new() { Guid="52B19C38-72C0-4E0F-B051-EF11103F6220", Kind="驾驶员下车", English="U_AmmoPouch_Cav", Chinese="弹药包", ShortName="Ammo Pouch", ImageName="GadgetSmallAmmoPack-5837fde5.png" },
        new() { Guid="9BCDB1F5-5E1C-4C3E-824C-8C05CC0CE21A", Kind="驾驶员下车", English="U_Bandages_Cav", Chinese="绷带包", ShortName="Bandages", ImageName="GadgetBandages-1d1fc900.png" },
        new() { Guid="D4A99456-2ABA-4376-9870-200FD24C5D45", Kind="驾驶员下车", English="U_Grenade_AT_Cavalry", Chinese="轻型反坦克手榴弹", ShortName="Grenade AT", ImageName="GadgetTrooperATGrenade-a6575030.png" },
        new() { Guid="009736C2-B237-49AE-9DD1-E77AF7771FF2", Kind="驾驶员下车", English="U_LugerP08_VhKit", Chinese="P08 手枪", ShortName="LugerP08 VhKit", ImageName="LugerP08-7f07aa2d.png" },
        
        ////////////////////////////////
        
        new() { Guid="C71A02C3-608E-42AA-9179-A4324A4D4539", Kind="特殊载具", English="ID_P_INAME_U_MORTAR", Chinese="特殊载具 空爆迫击炮", ShortName="MORTAR", ImageName="MortarAirburst-77c9647f.png" },
        new() { Guid="8BD0FABD-DCCE-4031-8156-B77866FCE1A0", Kind="特殊载具", English="ID_P_INAME_MORTAR_HE", Chinese="特殊载具 高爆迫击炮", ShortName="MORTAR HE", ImageName="GadgetMortar-84e30045.png" },
            
        /////////////////////////////////////////////////////////////////////////////

        // 运输载具        
        new() { Guid="1F37F90F-F85E-A4EA-0CA0-977FBC04DB6C", Kind="运输载具", English="ID_P_VNAME_MODEL30", Chinese="运输载具 M30 侦察车", ShortName="MODEL30", ImageName="USADodgeScoutCar-843c9c16.png" },
        new() { Guid="A9D9062B-FFEC-429E-9DD5-E24EB9D9C51B", Kind="运输载具", English="ID_P_VNAME_MERCEDES_37", Chinese="运输载具 37/95 侦察车", ShortName="MERCEDES 37", ImageName="AHU_Mercedes_37_95-69b407d2.png" },
        new() { Guid="F73DA041-0864-4782-BEDD-D9C08D86DA7D", Kind="运输载具", English="ID_P_VNAME_BENZ_MG", Chinese="运输载具 KFT 侦察车", ShortName="BENZ MG", ImageName="GER_Benz_MGCarrier-474daf7b.png" },
        new() { Guid="56C8EC6A-6667-547E-8393-B047A1BCB730", Kind="运输载具", English="ID_P_VNAME_MOTORCYCLE", Chinese="运输载具 MC 18J 附边车摩托车", ShortName="MOTORCYCLE", ImageName="USAHarleyDavidsson18J-27b0d7ef.png" },
        new() { Guid="41A7B28A-FE39-4FC8-9AA3-9AD7BC4F6A3C", Kind="运输载具", English="ID_P_VNAME_NSU", Chinese="运输载具 MC 3.5HP  附边车摩托车", ShortName="NSU", ImageName="GER_NSU_1914-e1a63515.png" },
        new() { Guid="7FEDA17B-6A27-1946-A02E-AA72A72FBCD7", Kind="运输载具", English="ID_P_VNAME_ROLLS", Chinese="运输载具 RNAS 装甲车", ShortName="ROLLS", ImageName="GBRRollsRoyceArmoredCar-4c6ccdf0.png" },
        new() { Guid="045085BF-D9E2-476F-9363-C11DD9BDDC61", Kind="运输载具", English="ID_P_VNAME_ROMFELL", Chinese="运输载具 Romfell 装甲车", ShortName="ROMFELL", ImageName="GER_Romfell-79d5be52.png" },
        new() { Guid="B30F9312-6887-46C5-873F-2670906856AE", Kind="运输载具", English="ID_P_VNAME_EHRHARDT", Chinese="运输载具 EV4 装甲车", ShortName="EHRHARDT", ImageName="GER_Ehrhardt_EV4-1e718572.png" },
        new() { Guid="87E38FC3-022D-4A88-80B5-6E3BD58C320F", Kind="运输载具", English="ID_P_VNAME_TERNI", Chinese="运输载具 F.T. 装甲车", ShortName="TERNI", ImageName="ITA_Fiat_Terni-3d8076d6.png" },
        new() { Guid="FA740EE6-6C1E-2F97-D48B-0EF8D1C7D11B", Kind="运输载具", English="ID_P_VNAME_MAS15", Chinese="运输载具 M.A.S 鱼雷快艇", ShortName="MAS15", ImageName="ITAMAS-51e28b0e.png" },
        new() { Guid="EA1C556F-DC5A-4764-BE8F-E661AF2B2C3B", Kind="运输载具", English="ID_P_VNAME_YLIGHTER", Chinese="运输载具 Y-Lighter 登陆艇", ShortName="MAS15", ImageName="GBR_Y_Lighter-468f2eaa.png" },
        
        /////////////////////////////////////////////////////////////////////////////

        // 定点武器
        new() { Guid="E7825334-17D9-3BA1-D59C-8497155B8DBB", Kind="定点武器", English="ID_P_VNAME_FIELDGUN", Chinese="定点武器 FK 96 野战炮", ShortName="FIELDGUN", ImageName="GERFk96nA-760d0461.png" },
        new() { Guid="12689F49-C72C-6BFE-07E9-A26258C0FCA0", Kind="定点武器", English="ID_P_VNAME_TURRET", Chinese="定点武器 堡垒火炮", ShortName="TURRET", ImageName="FRAFortressTurret-9fb165ad.png" },
        new() { Guid="2E5402EF-6303-B756-AEE9-E7926AB5FEF8", Kind="定点武器", English="ID_P_VNAME_AASTATION", Chinese="定点武器 QF 1 防空炮", ShortName="AASTATION", ImageName="GBRQF1-63882f78.png" },
        new() { Guid="690ABB5C-7B7E-4609-B37A-2DB46C2F6287", Kind="定点武器", English="ID_P_INAME_MAXIM", Chinese="定点武器 重型机枪", ShortName="MAXIM", ImageName="GBRVickers-ea4826ae.png" },
        // A3C6FC16-2DF6-4719-9A5F-E079CDB928F3 定点武器 高爆机炮 GER_BeckerM_Stationary-c741a373.png
        new() { Guid="EFB07B81-BBA3-413E-AF40-221CC104C21D", Kind="定点武器", English="ID_P_VNAME_BL9", Chinese="定点武器 BL 9.2 攻城炮", ShortName="BL9", ImageName="GBRBL9-0a10176d.png" },
        new() { Guid="B3BFBF74-6475-598C-C097-06DA0375F14A", Kind="定点武器", English="ID_P_VNAME_COASTALBATTERY", Chinese="定点武器 350/52 o 岸防炮", ShortName="COASTALBATTERY", ImageName="DagoCoastalArtilleryGun-b4b737b1.png" },
        new() { Guid="??????", Kind="定点武器", English="ID_P_VNAME_SK45GUN", Chinese="定点武器 SK45 岸防炮", ShortName="SK45GUN", ImageName="" },
        
        /////////////////////////////////////////////////////////////////////////////
        
        // 战争巨兽
        new() { Guid="1A7DEECF-4F0E-E343-9644-D6D91DCAEC12", Kind="机械巨兽", English="ID_P_VNAME_ZEPPELIN", Chinese="机械巨兽 飞船 l30", ShortName="ZEPPELIN", ImageName="GERZeppelinL30-62618731.png" },
        new() { Guid="A3ED808E-1525-412B-8E77-9EB6902A55D2", Kind="机械巨兽", English="ID_P_VNAME_ARMOREDTRAIN", Chinese="机械巨兽 装甲列车", ShortName="ARMOREDTRAIN", ImageName="RUSArmoredTrain-564a4e48.png" },
        new() { Guid="003FCC0A-2758-8508-4774-78E66FA1B5E3", Kind="机械巨兽", English="ID_P_VNAME_IRONDUKE", Chinese="机械巨兽 无畏舰", ShortName="IRONDUKE", ImageName="GBRHMSIronDuke-3b82016f.png" },
        new() { Guid="BBFC5A91-B2FC-48D2-8913-658C08072E6E", Kind="机械巨兽", English="ID_P_VNAME_CHAR", Chinese="机械巨兽 Char 2C", ShortName="CHAR", ImageName="FRAChar2C-b8f3c0e2.png" },
        
        /////////////////////////////////////////////////////////////////////////////
        
        // 近战
        new() { Guid="E0F9C0D2-939A-4E89-AA8B-B3AF5ADA5C86", Kind="近战武器", English="U_GrenadeClub", Chinese="哑弹棒", ShortName="Grenade Club", ImageName="" },
        new() { Guid="5ECF98B5-035C-4D9E-99DA-0B5802E343B6", Kind="近战武器", English="U_Club", Chinese="棍棒", ShortName="Club", ImageName="" },
        
        // 其他
        new() { Guid="??????", Kind="其他", English="U_GasMask", Chinese="防毒面具", ShortName="Gas Mask", ImageName="" },
    };
}

public class WeaponInfo
{
    public string Guid;
    public string Kind;
    public string English;
    public string Chinese;
    public string ShortName;
    public string ImageName;

    public string GetWeaponImage()
    {
        return ClientUtil.GetHostImageURL($"Weapons\\{ImageName}");
    }

    public string GetWeapon2Image()
    {
        return ClientUtil.GetHostImageURL($"Weapons2\\{ImageName}");
    }
}