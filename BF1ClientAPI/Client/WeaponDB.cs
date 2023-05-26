using BF1ClientAPI.Utils;

namespace BF1ClientAPI.Client;

public static class WeaponDB
{
    /// <summary>
    /// All weapon information, ShortName no more than 16 characters
    /// </summary>
    public readonly static List<WeaponInfo> AllWeaponInfo = new()
    {
        // Pistols
        new() { Guid="3CE86D7C-9951-4B25-9FD6-A97CA94F4A20", Kind="SIDEARM", Id="U_M1911", Name="M1911", Kick="M1911", Image="Colt1911-ed324bf1.png" },
        new() { Guid="009736C2-B237-49AE-9DD1-E77AF7771FF2", Kind="SIDEARM", Id="U_LugerP08", Name="P08 Pistol", Kick="P08", Image="LugerP08-7f07aa2d.png" },
        new() { Guid="A666D907-0F72-4641-B43A-6AA756FFBC03", Kind="SIDEARM", Id="U_FN1903", Name="Mle 1903", Kick="M1903", Image="Mle1903-a0fe1ec3.png" },
        new() { Guid="4DD1FAD2-1CF1-496C-BE29-BDAEBC931D74", Kind="SIDEARM", Id="U_BorchardtC93", Name="C93", Kick="C93", Image="Mle1903-a0fe1ec3.png" },
        new() { Guid="87643E53-CD17-FFC4-167B-AA72301A323A", Kind="SIDEARM", Id="U_SmithWesson", Name="No. 3 Revolver", Kick="No3 Rev", Image="SmithWesson-e26b4f24.png" },
        new() { Guid="33F9105C-40C7-3980-7982-ADD4B9F6311A", Kind="SIDEARM", Id="U_Kolibri", Name="Kolibri", Kick="Kolibri", Image="KolibriPistol-ec20b160.png" },
        new() { Guid="64503392-4DDF-435D-8ABA-22730383E073", Kind="SIDEARM", Id="U_NagantM1895", Name="Nagant Revolver", Kick="Nagant Rev", Image="NagantM1895-05035f4a.png" },
        new() { Guid="84AF0AF5-D981-48BE-8665-CC24A278DA6E", Kind="SIDEARM", Id="U_Obrez", Name="Obrez Pistol", Kick="Obrez", Image="ObrezPistol-0c86b6ed.png" },
        new() { Guid="8680EFC0-CA02-43E0-8CA2-591FB279DD95", Kind="SIDEARM", Id="U_Webley_Mk6", Name="Revolver MkVI", Kick="Mk VI", Image="Webley_MK6-da81b474.png" },
        new() { Guid="AF3F421B-F68B-401D-94B4-B982EE6C8A91", Kind="SIDEARM", Id="U_M1911_Preorder_Hellfighter", Name="Hellfighter M1911", Kick="M1911 HF", Image="Colt1911-ed324bf1.png" },
        new() { Guid="B97A8C29-A567-437F-9B6C-9E1E8FD86BF9", Kind="SIDEARM", Id="U_LugerP08_Wep_Preorder", Name="Red Baron P08", Kick="P08 HNJ", Image="LugerP08-7f07aa2d.png" },
        new() { Guid="5962340E-AED8-4B93-A10E-D7C91FFD2460", Kind="SIDEARM", Id="U_M1911_Suppressed", Name="M1911 Silenced", Kick="M1911 XYQ", Image="M1911Silencer-d6c0e687.png" },
        new() { Guid="B9333E7C-3D7D-4147-A569-9FC9BB2B4F5D", Kind="SIDEARM", Id="U_SingleActionArmy", Name="Peacekeeper", Kick="Peacekeeper", Image="Colt_SAA-ef15294c.png" },
        new() { Guid="F7CED576-7629-402A-8598-4A4998C02E0A", Kind="SIDEARM", Id="U_M1911_Preorder_Triforce", Name="Doughboy M1911", Kick="M1911 BBXZ", Image="Colt1911-ed324bf1.png" },
        
        // Grenades
        new() { Guid="F0B75644-5B3F-45CD-9E42-9B67F3D4D37F", Kind="Grenade", Id="U_GermanStick", Name="Fragmentation Grenade", Kick="German Stick", Image="GadgetFragmented-8c15152e.png" },
        new() { Guid="F0B75644-5B3F-45CD-9E42-9B67F3D4D37F", Kind="Grenade", Id="U_FragGrenade", Name="Fragmentation Grenade", Kick="Frag Grenade", Image="GadgetFragmented-8c15152e.png" },
        new() { Guid="EE6AC80E-FFDF-4E5A-923D-209CE9B86BF4", Kind="Grenade", Id="U_GasGrenade", Name="Gas Grenade", Kick="Gas Grenade", Image="GadgetGas-2bee4386.png" },
        new() { Guid="F9A8C36F-F5B6-4946-B3B9-F5923564CD51", Kind="Grenade", Id="U_ImpactGrenade", Name="Impact Grenade", Kick="Impact Grenade", Image="GadgetImpact-f0c7f39e.png" },
        new() { Guid="8219207A-41E6-4ED2-A3E8-9690752EC40C", Kind="Grenade", Id="U_Incendiary", Name="Incendiary Grenade", Kick="Incendiary", Image="GadgetIncindiary-68d49a3a.png" },
        new() { Guid="67B5683D-D897-4881-BB86-DACB9947264E", Kind="Grenade", Id="U_MiniGrenade", Name="Mini Grenade", Kick="Mini Grenade", Image="GadgetMiniOffensive-2d19e08a.png" },
        new() { Guid="04CDC06B-F4B6-4696-BE9C-08E1D0D36347", Kind="Grenade", Id="U_SmokeGrenade", Name="Smoke Grenade", Kick="Smoke Grenade", Image="GadgetSmoke-af84f434.png" },
        new() { Guid="D4A99456-2ABA-4376-9870-200FD24C5D45", Kind="Grenade", Id="U_Grenade_AT", Name="Light Anti-Tank Grenade", Kick="AT Grenade", Image="GadgetTrooperATGrenade-a6575030.png" },
        new() { Guid="55D01566-4322-4EAE-AD13-9DDAF2C2F399", Kind="Grenade", Id="U_ImprovisedGrenade", Name="Improvised Grenade", Kick="Imsp Grenade", Image="ImprovisedGrenade-fea87071.png" },
        new() { Guid="DD1BBA84-A6AB-4A66-986F-2B2556F6E7B1", Kind="Grenade", Id="U_RussianBox", Name="Russian Standard Grenade", Kick="Russian Box", Image="RU_Grenade-a7e29a54.png" },

        ////////////////////////////////// Assault //////////////////////////////////

        // Assault Main Weapons
        new() { Guid="16D7C222-5ACA-4728-854D-6282E44846DC", Kind="SHOTGUN", Id="U_RemingtonM10_Wep_Slug", Name="Model 10-A Slug", Kick="10A XDK", Image="RemingtonM10-08ab3f5b.png" },
        new() { Guid="508E534A-A7A5-41A1-8F8F-FEDFA0AFDA93", Kind="SHOTGUN", Id="U_RemingtonM10_Wep_Choke", Name="Model 10-A Hunter", Kick="10A LR", Image="RemingtonM10-08ab3f5b.png" },
        new() { Guid="ED262207-65C8-46E1-B5D4-D7468143790F", Kind="SHOTGUN", Id="U_RemingtonM10", Name="Model 10-A Factory", Kick="10A YC", Image="RemingtonM10-08ab3f5b.png" },
        new() { Guid="9F97B37E-2A81-4AE3-A96A-4402B30BF184", Kind="SHOTGUN", Id="U_Winchester1897_Wep_Sweeper", Name="MM97 Trench Gun Sweeper", Kick="M97 SD", Image="WinchesterM1897-bb453195.png" },
        new() { Guid="EA7C6CF1-5801-4C52-8685-51B4C7B90CE9", Kind="SHOTGUN", Id="U_Winchester1897_Wep_LowRecoil", Name="M97 Trench Backbored", Kick="M97 BB", Image="WinchesterM1897-bb453195.png" },
        new() { Guid="20D21E3D-BA5F-4239-8F90-42FCDDA12F51", Kind="SHOTGUN", Id="U_Winchester1897_Wep_Choke", Name="M97 Trench Gun Hunter", Kick="M97 LR", Image="WinchesterM1897-bb453195.png" },
        new() { Guid="ADA8C89D-F213-401C-806C-B60483E2EEE7", Kind="SMG", Id="U_MP18_Wep_Trench", Name="MP 18 Trench", Kick="MP18 HGZ", Image="BergmannSchmeisserMP18-761af430.png" },
        new() { Guid="A498D568-2F50-449C-BA5D-6864AB34F8D2", Kind="SMG", Id="U_MP18_Wep_Burst", Name="MP 18 Experimental", Kick="MP18 SY", Image="BergmannSchmeisserMP18-761af430.png" },
        new() { Guid="765A6856-3A80-4196-8DB6-14A95B94AB85", Kind="SMG", Id="U_MP18_Wep_Accuracy", Name="MP 18 Optical", Kick="MP18 MZJ", Image="BergmannSchmeisserMP18-761af430.png" },
        new() { Guid="58E00507-4123-49D9-A9DE-0F5C7A267CC4", Kind="SMG", Id="U_BerettaM1918_Wep_Trench", Name="Automatico M1918 Trench", Kick="MP1918 HGZ", Image="Beretta1918-3daab991.png" },
        new() { Guid="29539D1A-A492-4398-BABF-6BC8DBD4BECA", Kind="SMG", Id="U_BerettaM1918_Wep_Stability", Name="Automatico M1918 Storm", Kick="MP1918 CF", Image="Beretta1918-3daab991.png" },
        new() { Guid="2439B810-3ACD-4069-B1E9-0CDC2CE51985", Kind="SMG", Id="U_BerettaM1918", Name="Automatico M1918 Factory", Kick="MP1918 YC", Image="Beretta1918-3daab991.png" },
        new() { Guid="FA78AFDF-D06D-4CBE-B325-945F9B4091C3", Kind="SHOTGUN", Id="U_BrowningA5_Wep_LowRecoil", Name="12g Automatic Backbored", Kick="12g BB", Image="BrowingA5-95b260b4.png" },
        new() { Guid="31D6D032-5B6F-4494-A04A-0FB8EDB130BB", Kind="SHOTGUN", Id="U_BrowningA5_Wep_Choke", Name="12g Automatic Hunter", Kick="12g LR", Image="BrowingA5-95b260b4.png" },
        new() { Guid="D7A0DED9-EC54-4523-9294-656FA1881FE9", Kind="SHOTGUN", Id="U_BrowningA5_Wep_ExtensionTube", Name="12g Automatic Extended", Kick="12g JC", Image="BrowingA5-95b260b4.png" },
        new() { Guid="2B253855-7BA0-4FF6-9F25-57D53B15FE32", Kind="SMG", Id="U_Hellriegel1915", Name="Hellriegel 1915 Factory", Kick="H1915 YC", Image="Hellriegel1915-e2513c1e.png" },
        new() { Guid="B1E5A3BC-3D24-4FE5-84D1-4523D6DCE545", Kind="SMG", Id="U_Hellriegel1915_Wep_Accuracy", Name="Hellriegel 1915 Defensive", Kick="H1915 FY", Image="Hellriegel1915-e2513c1e.png" },
        new() { Guid="8F241031-A76D-436B-AE5F-CD797B504A7A", Kind="SHOTGUN", Id="U_Winchester1897_Wep_Preorder", Name="Hellfighter Trench M1897", Kick="M97 DYZS", Image="WinchesterM1897-bb453195.png" },
        new() { Guid="5D89166E-58E1-46FD-B854-69641E9DCEF7", Kind="SHOTGUN", Id="U_SjogrenShotgun", Name="Sjögren Inertial Factory", Kick="RDP YC", Image="SjogrenShotgun-e95b3db0.png" },
        new() { Guid="42B442BF-6ACE-4592-A53B-96424B4ACABF", Kind="SHOTGUN", Id="U_SjogrenShotgun_Wep_Slug", Name="Sjögren Inertial Slug", Kick="RDP XDK", Image="SjogrenShotgun-e95b3db0.png" },
        new() { Guid="6B07DE60-5568-43C0-B1F6-D51A13A9BD3C", Kind="SMG", Id="U_Ribeyrolles", Name="Ribeyrolles 1918 Factory", Kick="L1918 YC", Image="Ribeyrolles-0e43197c.png" },
        new() { Guid="C4B84F0E-D7FF-49D9-9796-E6CF95C058BD", Kind="SMG", Id="U_Ribeyrolles_Wep_Optical", Name="Ribeyrolles 1918 Optical", Kick="L1918 MZJ", Image="Ribeyrolles-0e43197c.png" },
        new() { Guid="CCA1F8F7-5658-4DCA-BAA8-2C930C2EF5F0", Kind="SHOTGUN", Id="U_RemingtonModel1900", Name="Model 1900 Factory", Kick="M1900 YC", Image="RemingtonModel1900-e80b885b.png" },
        new() { Guid="55381B1D-7E17-44BE-AC0B-33542A64BF96", Kind="SHOTGUN", Id="U_RemingtonModel1900_Wep_Slug", Name="Model 1900 Slug", Kick="M1900 XDK", Image="RemingtonModel1900-e80b885b.png" },
        new() { Guid="C4F8BC18-1908-4A83-ABB6-B812C05D49CE", Kind="SMG", Id="U_MaximSMG", Name="SMG 08/18 Factory", Kick="SMG0818 YC", Image="MaximSMG-c3563db7.png" },
        new() { Guid="DEC97287-AF0B-49E4-8FD8-CBC5FB5AF497", Kind="SMG", Id="U_MaximSMG_Wep_Accuracy", Name="SMG 08/18 Optical", Kick="SMG0818 MZJ", Image="MaximSMG-c3563db7.png" },
        new() { Guid="E1297C9B-861A-4170-840B-83AC64A0C574", Kind="PISTOL CARBINE", Id="U_SteyrM1912_P16", Name="Maschinenpistole M1912", Kick="M1912 P.16 CF", Image="SteyrM1912Stock-a1ad884f.png" },
        new() { Guid="39137F1F-B794-4265-BB30-490E1E182F81", Kind="PISTOL CARBINE", Id="U_SteyrM1912_P16_Wep_Burst", Name="Maschinenpistole M1912 Experimental", Kick="M1912 P.16 SY", Image="SteyrM1912Stock-a1ad884f.png" },
        new() { Guid="1C5B531F-26B4-429F-839B-99252610A7F0", Kind="PISTOL CARBINE", Id="U_Mauser1917Trench", Name="M1917 Trench Carbine", Kick="M1917 KBQ ZH", Image="MauserM1917TrenchCarbine-9a4158a1.png" },
        new() { Guid="245A23B1-53BA-4AB2-A416-224794F15FCB", Kind="PISTOL CARBINE", Id="U_Mauser1917Trench_Wep_Scope", Name="M1917 Patrol Carbine", Kick="M1917 KBQ XL", Image="MauserM1917TrenchCarbine-9a4158a1.png" },
        new() { Guid="6C3EE48B-0974-48B1-AFF7-96FD4D684E82", Kind="SMG", Id="U_ChauchatSMG", Name="RSC SMG Factory", Kick="RSC YC", Image="Chauchat-Ribeyrolles-4af8a912.png" },
        new() { Guid="6DAFDE21-2502-41B4-878B-532E70905238", Kind="SMG", Id="U_ChauchatSMG_Wep_Optical", Name="RSC SMG Optical", Kick="RSC MZJ", Image="Chauchat-Ribeyrolles-4af8a912.png" },
        new() { Guid="C70FE9E0-0A1C-470C-B377-68059953EAD8", Kind="SMG", Id="U_M1919Thompson_Wep_Trench", Name="Annihilator Trench", Kick="Annihilator HG", Image="ThompsonAnnihilatorTr-1a660e74.png" },
        new() { Guid="DBC25B43-29D9-4FB4-B9EF-C4966CD773B3", Kind="SMG", Id="U_M1919Thompson_Wep_Stability", Name="Annihilator Storm", Kick="Annihilator CF", Image="ThompsonAnnihilatorTr-1a660e74.png" },
        new() { Guid="A9985C95-7364-4AE3-BC77-C53651128EBE", Kind="SMG", Id="U_M1919Thompson", Name="M1919 SMG", Kick="M1919", Image="M1919Thompson-1cf7343d.png" },
        new() { Guid="D8AEB334-58E2-4A52-83BA-F3C2107196F0", Kind="PISTOL CARBINE", Id="U_FrommerStopAuto", Name="Frommer Stop Auto", Kick="FrommerStopAuto", Image="FrommerStop-506df97e.png" },
        new() { Guid="7085A5B9-6A77-4766-83CD-3666DA3EDF28", Kind="SHOTGUN", Id="U_SawnOffShotgun", Name="Sawed Off Shotgun", Kick="SawnOffShotgun", Image="SawedOfShotgun-d31e0dd8.png" },

        // Assault Sidearms
        new() { Guid="F5F1FAA5-1791-441F-BDB5-82F9A4D14BAF", Kind="SIDEARM", Id="U_GasserM1870", Name="Gasser M1870", Kick="M1870", Image="GasserM1870-00471df4.png" },
        new() { Guid="25B28666-332D-4FCB-AD68-18184AD37702", Kind="SIDEARM", Id="U_LancasterHowdah", Name="Howdah Pistol", Kick="Howdah", Image="LancasterHowdah-9100578c.png" },
        new() { Guid="E0C46F74-92CF-0C0C-E475-806B37E14706", Kind="SIDEARM", Id="U_Hammerless", Name="1903 Hammerless", Kick="1903", Image="Hammerless-e61505d4.png" },

        // Assault Gadgets
        new() { Guid="079D8793-073C-4332-A959-19C74A9D2A46", Kind="GADGET", Id="U_Dynamite", Name="Dynamite", Kick="Dynamite", Image="GadgetDynamite-b6283212.png" },
        new() { Guid="72CCBF3E-C0FE-4657-A1A7-EACDB2D11985", Kind="GADGET", Id="U_ATGrenade", Name="Anti-Tank Grenade", Kick="ATGrenade", Image="GadgetATGrenade-4b135d46.png" },
        new() { Guid="6DFD1536-BBBB-4528-917A-7E2821FB4B6B", Kind="GADGET", Id="U_ATMine", Name="Anti-Tank Mine", Kick="ATMine", Image="GadgetMine-527cef72.png" },
        new() { Guid="BE041F1A-460B-4FD5-9E4B-F1C803C0F42F", Kind="GADGET", Id="U_BreechGun", Name="AT Rocket Gun", Kick="AT", Image="GadgetBreechgun-f2188c3f.png" },
        new() { Guid="AE96B513-1F05-4E63-A273-E98FA91EE4D0", Kind="GADGET", Id="U_BreechGun_Flak", Name="AA Rocket Gun", Kick="AAT", Image="AA-Rocket-Gun-49a4e8d1.png" },

        ////////////////////////////////// Medic //////////////////////////////////

        // Medic Main Weapons
        new() { Guid="DE3E0902-9C36-4CFA-B872-49282591F11C", Kind="SELF-LOADING RIFLE", Id="U_CeiRigottiM1895_Wep_Trench", Name="Cei-Rigotti Trench", Kick="M1895 HGZ", Image="CeiRigotti-8ae129e0.png" },
        new() { Guid="D71DA743-8F97-430B-A794-50F7974C28EC", Kind="SELF-LOADING RIFLE", Id="U_CeiRigottiM1895_Wep_Range", Name="Cei-Rigotti Optical", Kick="M1895 MZJ", Image="CeiRigotti-8ae129e0.png" },
        new() { Guid="12EE7056-0D58-4570-ADA6-06D9062DE408", Kind="SELF-LOADING RIFLE", Id="U_CeiRigottiM1895", Name="Cei-Rigotti Factory", Kick="M1895 YC", Image="CeiRigotti-8ae129e0.png" },
        new() { Guid="EDF7E9DB-5847-4E21-9EF0-C1E01ED80D8B", Kind="SELF-LOADING RIFLE", Id="U_MauserSL1916_Wep_Scope", Name="SSelbstlader M1916 Marksman", Kick="M1916 SSS", Image="MauserSelbstladerM1916-c86e8775.png" },
        new() { Guid="88336091-0676-4B12-BA91-810C25ED67C4", Kind="SELF-LOADING RIFLE", Id="U_MauserSL1916_Wep_Range", Name="Selbstlader M1916 Optical", Kick="M1916 MZJ", Image="MauserSelbstladerM1916-c86e8775.png" },
        new() { Guid="3DCA71EC-EBCC-464C-B3CD-7251372FC0AD", Kind="SELF-LOADING RIFLE", Id="U_MauserSL1916", Name="Selbstlader M1916 Factory", Kick="M1916 YC", Image="MauserSelbstladerM1916-c86e8775.png" },
        new() { Guid="2DFEF12D-7110-47F9-9185-78A081BDE76A", Kind="SELF-LOADING RIFLE", Id="U_WinchesterM1907_Wep_Trench", Name="M1907 SL Trench", Kick="M1907 JGZ", Image="WinchesterM1907-3e99346c.png" },
        new() { Guid="A9507FBD-8B45-49E6-803C-53A5D5EE0406", Kind="SELF-LOADING RIFLE", Id="U_WinchesterM1907_Wep_Auto", Name="M1907 SL Sweeper", Kick="M1907 SD", Image="WinchesterM1907-3e99346c.png" },
        new() { Guid="DD36E432-B119-4D0F-95A1-541493BF7EE6", Kind="SELF-LOADING RIFLE", Id="U_WinchesterM1907", Name="M1907 SL Factory", Kick="M1907 YC", Image="WinchesterM1907-3e99346c.png" },
        new() { Guid="08AD9E6C-D453-48F4-BDE5-CF84652A12F0", Kind="SELF-LOADING RIFLE", Id="U_Mondragon_Wep_Range", Name="Mondragon Optical", Kick="Mondragon MZJ", Image="Mondragon-a3950be7.png" },
        new() { Guid="EDECA6B4-795F-45B2-BD3F-967E96D40C7D", Kind="SELF-LOADING RIFLE", Id="U_Mondragon_Wep_Stability", Name="Mondragon Storm", Kick="Mondragon CF", Image="Mondragon-a3950be7.png" },
        new() { Guid="BEB31317-EBBF-45FB-A102-0E115DAA5551", Kind="SELF-LOADING RIFLE", Id="U_Mondragon_Wep_Bipod", Name="Mondragon Sniper", Kick="Mondragon JJS", Image="Mondragon-a3950be7.png" },
        new() { Guid="1F42E46E-603B-4325-AA42-31B86210D47C", Kind="SELF-LOADING RIFLE", Id="U_RemingtonModel8", Name="Autoloading 8.35 Factory", Kick="8.35 YC", Image="RemingtonM8_Special-398391d9.png" },
        new() { Guid="2066B449-91C9-4B9C-8C4C-40F5B9F0A58E", Kind="SELF-LOADING RIFLE", Id="U_RemingtonModel8_Wep_Scope", Name="Autoloading 8.35 Marksman", Kick="8.35 SSS", Image="RemingtonM8_Special-398391d9.png" },
        new() { Guid="9E7BE0C2-E44D-4B4F-99A7-B05D4451D254", Kind="SELF-LOADING RIFLE", Id="U_RemingtonModel8_Wep_ExtendedMag", Name="Autoloading 8.25 Extended", Kick="8.25 JC", Image="RemingtonM8_Special-398391d9.png" },
        new() { Guid="47BEB21C-2CD6-4ED0-8253-33F8F980EB94", Kind="SELF-LOADING RIFLE", Id="U_Luger1906", Name="Selbstlader 1906 Factory", Kick="1906 YC", Image="Luger1906-3238a6b3.png" },
        new() { Guid="5B483B03-DD23-4E38-83C7-CD841A6E9927", Kind="SELF-LOADING RIFLE", Id="U_Luger1906_Wep_Scope", Name="Selbstlader 1906 Sniper", Kick="1906 JJS", Image="Luger1906-3238a6b3.png" },
        new() { Guid="F73F9323-CD36-41F6-BFB7-3A2244342E70", Kind="SELF-LOADING RIFLE", Id="U_RSC1917_Wep_Range", Name="RSC 1917 Optical", Kick="RSC 1917 MZJ", Image="RSC1917-35904a91.png" },
        new() { Guid="0051C834-6CF9-4CFB-BFBA-E54AF000A9E5", Kind="SELF-LOADING RIFLE", Id="U_RSC1917", Name="RSC 1917 Factory", Kick="RSC 1917 YC", Image="RSC1917-35904a91.png" },
        new() { Guid="207B1E7D-B45A-4622-B482-7CAE22C1539F", Kind="SELF-LOADING RIFLE", Id="U_FedorovAvtomat_Wep_Trench", Name="Fedorov Avtomat Trench", Kick="Fedorov HGZ", Image="FederovAvtomat-aa228b15.png" },
        new() { Guid="9E799054-23D4-4525-B777-6A30E99DA964", Kind="SELF-LOADING RIFLE", Id="U_FedorovAvtomat_Wep_Range", Name="Fedorov Avtomat Trench", Kick="Fedorov MZJ", Image="FederovAvtomat-aa228b15.png" },
        new() { Guid="652BC7DF-9F78-4D93-BF96-2B6F9B6CE75C", Kind="SELF-LOADING RIFLE", Id="U_GeneralLiuRifle", Name="General Liu Rifle Factory", Kick="GeneralLiu YC", Image="GeneralLiu-f926d015.png" },
        new() { Guid="52208E58-292B-4B03-90C7-B620C9F582C9", Kind="SELF-LOADING RIFLE", Id="U_GeneralLiuRifle_Wep_Stability", Name="General Liu Rifle Storm", Kick="GeneralLiu CF", Image="GeneralLiu-f926d015.png" },
        new() { Guid="71A33B25-58E3-4F65-90EB-F69042978D99", Kind="SELF-LOADING RIFLE", Id="U_FarquharHill_Wep_Range", Name="Farquhar-Hill Optical", Kick="Farquhar MZJ", Image="FarquharHill-11f5925b.png" },
        new() { Guid="53884B2B-4DEF-4A02-BEEE-0E7B6D39205E", Kind="SELF-LOADING RIFLE", Id="U_FarquharHill_Wep_Stability", Name="Farquhar-Hill Storm", Kick="Farquhar CF", Image="FarquharHill-11f5925b.png" },
        new() { Guid="11A0CC2F-9DE9-42FC-B528-91822B760819", Kind="SELF-LOADING RIFLE", Id="U_BSAHowellM1916", Name="Howell Automatic Factory", Kick="Howell YC", Image="BSA_Howell-c3f2e18b.png" },
        new() { Guid="8DFC892E-00AE-47EC-A1D3-B866D40EE587", Kind="SELF-LOADING RIFLE", Id="U_BSAHowellM1916_Wep_Scope", Name="Howell Automatic Sniper", Kick="Howell JJS", Image="BSA_Howell-c3f2e18b.png" },
        new() { Guid="4CFA2055-EB98-48E6-9BD9-70AAE7AF04AE", Kind="SELF-LOADING RIFLE", Id="U_FedorovDegtyarev", Name="Fedorov Degtyarev", Kick="Fedorov SL", Image="FederovDegtyarev-ed497b9d.png" },

        // Medic Sidearms
        new() { Guid="447B3866-1241-42D7-8AB2-384727CFE624", Kind="SIDEARM", Id="U_WebFosAutoRev_455Webley", Name="Auto Revolver", Kick="Auto Rev", Image="WebleyFosberyAutoRevolver-a57ea28c.png" },
        new() { Guid="169D5DA6-8DB5-48B3-8101-DB208C4BB4DD", Kind="SIDEARM", Id="U_MauserC96", Name="C96", Kick="C96", Image="MauserC96-52835b08.png" },
        new() { Guid="8373B804-511A-AB86-256D-9CE36CE25BA5", Kind="SIDEARM", Id="U_Mauser1914", Name="Taschenpistole M1914", Kick="M1914", Image="Mauser1914-53a1954e.png" },

        // Medic Gadgets
        new() { Guid="EBA4454E-EEB6-4AF1-9286-BD841E297ED4", Kind="GADGET", Id="U_Syringe", Name="Syringe", Kick="Syringe", Image="GadgetSyringe-e6c764c2.png" },
        new() { Guid="670F817E-89A6-4048-B8B2-D9997DD97982", Kind="GADGET", Id="U_MedicBag", Name="Medical Crate", Kick="MedicBag", Image="GadgetMedicBag-159f240b.png" },
        new() { Guid="9BCDB1F5-5E1C-4C3E-824C-8C05CC0CE21A", Kind="GADGET", Id="U_Bandages", Name="Bandage Pouch", Kick="Bandages", Image="GadgetBandages-1d1fc900.png" },
        new() { Guid="F34B3039-7B3A-0272-14E7-628980A60F06", Kind="GADGET", Id="_RGL_Frag", Name="Rifle Grenade - FRG", Kick="RGL Frag", Image="MedicRifleLauncher_B-a712e224.png" },
        new() { Guid="03FDF635-8E98-4F74-A176-DB4960304DF5", Kind="GADGET", Id="_RGL_Smoke", Name="Rifle Grenade - SMK", Kick="RGL Smoke", Image="MedicRifleLauncher_A-438b725e.png" },
        new() { Guid="165ED044-C2C5-43A1-BE04-8618FA5072D4", Kind="GADGET", Id="_RGL_HE", Name="Rifle Grenade - HE", Kick="RGL HE", Image="MedicRifleLauncher_B-a712e224.png" },

        ////////////////////////////////// Support //////////////////////////////////

        // Support Main Weapons
        new() { Guid="B524273C-77FD-433E-8A40-270C00A4AE67", Kind="LMG", Id="U_LewisMG_Wep_Suppression", Name="Lewis Gun Suppressive", Kick="LewisMG YZ", Image="LewisLMG-832c29e8.png" },
        new() { Guid="CCE43311-3362-4D84-91D0-6A3D83B9BA17", Kind="LMG", Id="U_LewisMG_Wep_Range", Name="Lewis Gun Optical", Kick="LewisMG MZJ", Image="LewisLMG-832c29e8.png" },
        new() { Guid="B79B965E-E080-475D-A1CC-2432DE5F3BF5", Kind="LMG", Id="U_LewisMG", Name="Lewis Gun Low Wight", Kick="LewisMG QLH", Image="LewisLMG-832c29e8.png" },
        new() { Guid="465A4240-78EA-4648-868F-40EA06D5DC06", Kind="LMG", Id="U_HotchkissM1909_Wep_Stability", Name="M1909 Benét-Mercié Storm", Kick="M1909 CF", Image="HotchkissLMG-06defda3.png" },
        new() { Guid="02721F8C-6901-4389-B56A-89C3AC93C889", Kind="LMG", Id="U_HotchkissM1909_Wep_Range", Name="M1909 Benét-Mercié Optical", Kick="M1909 MZJ", Image="HotchkissLMG-06defda3.png" },
        new() { Guid="94286083-BE6A-46C0-AFAF-011635458AAA", Kind="LMG", Id="U_HotchkissM1909_Wep_Bipod", Name="M1909 Benét-Mercié Telescopic", Kick="M1909 WYMJ", Image="HotchkissLMG-06defda3.png" },
        new() { Guid="75DEC4E1-9A85-43A3-BBDE-9908F7A65D23", Kind="LMG", Id="U_MadsenMG_Wep_Trench", Name="Madsen MG Trench", Kick="MadsenMG HGZ", Image="MadsenMG-51e41523.png" },
        new() { Guid="6E9863F2-2A32-4A0A-8F6C-BBC668044B15", Kind="LMG", Id="U_MadsenMG_Wep_Stability", Name="Madsen MG Storm", Kick="MadsenMG CF", Image="MadsenMG-51e41523.png" },
        new() { Guid="E2812647-A994-413B-B24F-24CAF2578551", Kind="LMG", Id="U_MadsenMG", Name="Madsen MG Low Weight", Kick="MadsenMG QLH", Image="MadsenMG-51e41523.png" },
        new() { Guid="2F0B54CD-CA30-4E9C-9384-5E967C478845", Kind="LMG", Id="U_Bergmann1915MG_Wep_Suppression", Name="MG15 n.A. Suppressive", Kick="MG15 YZ", Image="Bergmann1915MG-891af31f.png" },
        new() { Guid="FFD12D82-9187-4F1A-823F-0F61E766EC98", Kind="LMG", Id="U_Bergmann1915MG_Wep_Stability", Name="MG15 n.A. Storm", Kick="MG15 CF", Image="Bergmann1915MG-891af31f.png" },
        new() { Guid="64BE05D1-CE33-4DE5-9458-AB083C776635", Kind="LMG", Id="U_Bergmann1915MG", Name="MG15 n.A. Low Weight", Kick="MG15 QLH", Image="Bergmann1915MG-891af31f.png" },
        new() { Guid="3231A399-B1DB-4D04-B286-1338092424B9", Kind="LMG", Id="U_BARM1918_Wep_Trench", Name="BAR 1918 Trench", Kick="M1918 HGZ", Image="Barm1918-3c14511c.png" },
        new() { Guid="7D987B4E-A08C-41AD-A68B-245FBB5B10EF", Kind="LMG", Id="U_BARM1918_Wep_Stability", Name="BAR 1918 Storm", Kick="M1918 CF", Image="Barm1918-3c14511c.png" },
        new() { Guid="2D800408-99C2-4A84-9B8E-C713F4B6C450", Kind="LMG", Id="U_BARM1918_Wep_Bipod", Name="BAR 1918 Telescopic", Kick="M1918 WYMJ", Image="Barm1918-3c14511c.png" },
        new() { Guid="AB16FE32-BC40-4AB0-9F8C-07AADBBC1E4E", Kind="LMG", Id="U_BARM1918A2", Name="M1918A2 白朗宁自动步枪", Kick="M1918A2", Image="BARM1918A2-48c755b2.png" },
        new() { Guid="5C2C5A64-6227-4FA3-A382-E9DD68C66DAD", Kind="LMG", Id="U_HuotAutoRifle", Name="Huot Automatic Low Weight", Kick="Huot QLH", Image="HuotAutoRifle-4ab70c1a.png" },
        new() { Guid="EE0A0210-4B5F-48DC-A02F-5879C24B1580", Kind="LMG", Id="U_HuotAutoRifle_Wep_Range", Name="Huot Automatic Optical", Kick="Huot HGZ", Image="HuotAutoRifle-4ab70c1a.png" },
        new() { Guid="20BB8B94-1A01-4D8E-A2C7-7D19CE440802", Kind="LMG", Id="U_Chauchat", Name="Chauchat Low Weight", Kick="Chauchat QLH", Image="Chauchat-787ad478.png" },
        new() { Guid="2C12E5FE-909A-4F0C-99FD-B23FBD1A6B4C", Kind="LMG", Id="U_Chauchat_Wep_Bipod", Name="Chauchat Telescopic", Kick="Chauchat WYMJ", Image="Chauchat-787ad478.png" },
        new() { Guid="37207FD2-BD0C-460A-A065-6D8A5DEE2334", Kind="LMG", Id="U_ParabellumLMG", Name="Parabellum MG14/17 Low Weight", Kick="MG1417 QLH", Image="ParabellumMG1417-09dccd5b.png" },
        new() { Guid="95BDD2DE-CF36-45E1-B2F6-1DC5B8F8E632", Kind="LMG", Id="U_ParabellumLMG_Wep_Suppression", Name="Parabellum MG14/17 Suppressive", Kick="MG1417 YZ", Image="ParabellumMG1417-09dccd5b.png" },
        new() { Guid="406A7149-CFBC-4CD4-8ED7-B388AB1B5501", Kind="LMG", Id="U_PerinoM1908", Name="Perino Model 1908 Low Weight", Kick="M1908 QLH", Image="Perino1908-e97144b1.png" },
        new() { Guid="1B3EA625-4AFD-465D-AC16-16356B26BB82", Kind="LMG", Id="U_PerinoM1908_Wep_Defensive", Name="Perino Model 1908 Defensive", Kick="M1908 FY", Image="Perino1908-e97144b1.png" },
        new() { Guid="BE397913-E33F-40B2-87C4-F7B92426AAA1", Kind="LMG", Id="U_BrowningM1917", Name="M1917 MG Low Weight", Kick="M1917 QLH", Image="Browning1917-61290bc9.png" },
        new() { Guid="96B134CC-5EDA-436A-9913-5ED429C696DD", Kind="LMG", Id="U_BrowningM1917_Wep_Suppression", Name="M1917 MG Telescopic", Kick="M1917 WYMJ", Image="Browning1917-61290bc9.png" },
        new() { Guid="57D820BF-38CC-4F62-8069-617E063971A0", Kind="LMG", Id="U_MG0818", Name="lMG 08/18 Low Wright", Kick="MG0818 QLH", Image="LMG_08-18-743c1aa8.png" },
        new() { Guid="16DF4163-78E0-4926-929A-E6052E04BE7F", Kind="LMG", Id="U_MG0818_Wep_Defensive", Name="lMG 08/18 Suppressive", Kick="MG0818 YZ", Image="LMG_08-18-743c1aa8.png" },
        new() { Guid="6C8284DF-9CEC-4391-9E1B-0E355C2D1310", Kind="LMG", Id="U_WinchesterBurton_Wep_Trench", Name="Burton LMR Trench", Kick="Burton LMR ZH", Image="WinchesterBurton-ce3988cc.png" },
        new() { Guid="708392C1-38F7-4CFA-81E3-04FC90434021", Kind="LMG", Id="U_WinchesterBurton_Wep_Optical", Name="Burton LMR Optical", Kick="Burton LMR HZJ", Image="WinchesterBurton-ce3988cc.png" },
        new() { Guid="53B264D8-1E4D-42E9-AA31-401D55BA2F39", Kind="PISTOL-CARBINE", Id="U_MauserC96AutoPistol", Name="C96 Carbine", Kick="C96 KBQ", Image="MauserC96CCarbine-741ab77d.png" },
        new() { Guid="0CC870E0-7AAE-44FE-B9D8-5D90706AF38B", Kind="PISTOL-CARBINE", Id="U_LugerArtillery", Name="P08 Artillerie", Kick="P08 Artillerie", Image="LugerArtillery-1fbfb83c.png" },
        new() { Guid="6CB23E70-F191-4043-951A-B43D6D2CF4A2", Kind="PISTOL-CARBINE", Id="U_PieperCarbine", Name="Pieper M1893", Kick="M1893", Image="PieperCarbine-31e63cfb.png" },
        new() { Guid="3DC12572-2D2F-4439-95CA-8DFB80BA17F5", Kind="PISTOL-CARBINE", Id="U_M1911_Stock", Name="M1911 Extended", Kick="M1911 JC", Image="M1911ExtendedMag-eb019f60.png" },
        new() { Guid="2B421852-CFF9-41FF-B385-34580D5A9BF0", Kind="PISTOL-CARBINE", Id="U_FN1903stock", Name="Mle 1903 Extended", Kick="Mle 1903 JC", Image="FN1903stock-d8904447.png" },
        new() { Guid="EBE043CB-8D37-4807-9260-E2DD7EFC4BD2", Kind="PISTOL-CARBINE", Id="U_C93Carbine", Name="C93 Carbine", Kick="C93 KBQ", Image="C93CarbineSup-120665d1.png" },

        // Support Sidearms
        new() { Guid="333D0B8C-404B-4B99-9588-B01736E0B742", Kind="SIDEARM", Id="U_SteyrM1912", Name="Repetierpistole M1912", Kick="M1912", Image="SteyrM1912-a49c97dd.png" },
        new() { Guid="B8EA5E4D-5B6A-9958-473F-20E8B2088CFD", Kind="SIDEARM", Id="U_Bulldog", Name="Bulldog Revolver", Kick="Bulldog", Image="Bulldog-d95cfd90.png" },
        new() { Guid="101FAD96-0E8B-4AB2-9299-299A15CB5BF1", Kind="SIDEARM", Id="U_BerettaM1915", Name="Modello 1915", Kick="Modello 1915", Image="Beretta1915-e2c3c8d8.png" },
        new() { Guid="CF71A87B-2BD4-4AF8-AE80-D3B9F6F5CEDE", Kind="SIDEARM", Id="U_M1911_A1", Name="M1911A1", Kick="M1911A1", Image="Colt1911-ed324bf1.png" },

        // Support Gadgets
        new() { Guid="2B0EC5C1-81A5-424A-A181-29B1E9920DDA", Kind="GADGET", Id="U_AmmoCrate", Name="Ammo Crate", Kick="Ammo Crate", Image="GadgetAmmoCrate-61f48e78.png" },
        new() { Guid="52B19C38-72C0-4E0F-B051-EF11103F6220", Kind="GADGET", Id="U_AmmoPouch", Name="Ammo Puch", Kick="Ammo Pouch", Image="GadgetSmallAmmoPack-5837fde5.png" },
        new() { Guid="C71A02C3-608E-42AA-9179-A4324A4D4539", Kind="GADGET", Id="U_Mortar", Name="Mortar - AIR", Kick="Mortar FRG", Image="MortarAirburst-77c9647f.png" },
        new() { Guid="8BD0FABD-DCCE-4031-8156-B77866FCE1A0", Kind="GADGET", Id="U_Mortar_HE", Name="Mortar - HE", Kick="Mortar HE", Image="GadgetMortar-84e30045.png" },
        new() { Guid="F59AA727-6618-4C1D-A5E2-007044CA3B89", Kind="GADGET", Id="U_Wrench", Name="Repair Tool", Kick="Wrench", Image="GadgetWrench-07e2c76d.png" },
        new() { Guid="95A5E9D8-E949-46C2-B5CA-36B3CA4C2E9D", Kind="GADGET", Id="U_LimpetMine", Name="Limpet Charge", Kick="Limpet Mine", Image="GadgetLimpetMine-a6d78b8f.png" },
        new() { Guid="02D4481F-FBC3-4C57-AAAC-1B37DC92751E", Kind="GADGET", Id="U_Crossbow", Name="Crossbow Launcher - FRG", Kick="Crossbow FRG", Image="crossbow-5f3dc5e6.png" },
        new() { Guid="60D24A79-BFD6-4C8F-B54F-D1AA6D2620DE", Kind="GADGET", Id="U_Crossbow_HE", Name="Crossbow Launcher - HE", Kick="Crossbow HE", Image="crossbow-5f3dc5e6.png" },

        ////////////////////////////////// Scout   //////////////////////////////////

        // Scout Main Weapons
        new() { Guid="11AAA000-BEA2-44E4-A463-11CE25CA4E93", Kind="RIFLE", Id="U_WinchesterM1895_Wep_Trench", Name="Russian 1895 Trench", Kick="1895 HGZ", Image="Winchester1895-69d56c0b.png" },
        new() { Guid="5BD7640B-2308-4CB9-98EB-26E4AB5AB1C9", Kind="RIFLE", Id="U_WinchesterM1895_Wep_Long", Name="Russian 1895 Sniper", Kick="1895 JJS", Image="Winchester1895-69d56c0b.png" },
        new() { Guid="4A960C79-5265-4559-B1D2-90E1B5BE7238", Kind="RIFLE", Id="U_WinchesterM1895", Name="Russian 1895 Infantry", Kick="1895 BB", Image="Winchester1895-69d56c0b.png" },
        new() { Guid="DA44F656-997F-4DD8-B3A2-34B9E057BE19", Kind="RIFLE", Id="U_Gewehr98_Wep_Scope", Name="Gewehr 98 Marksman", Kick="G98 SSS", Image="MauserGewehr98-f159616f.png" },
        new() { Guid="2E2F512C-D9DC-470E-86E0-8B5F827FEA8A", Kind="RIFLE", Id="U_Gewehr98_Wep_LongRange", Name="Gewehr 98 Sniper", Kick="G98 JJS", Image="MauserGewehr98-f159616f.png" },
        new() { Guid="2EEF7FFC-A1A4-4143-A0DF-3F41EF611433", Kind="RIFLE", Id="U_Gewehr98", Name="Gewehr 98 Infantry", Kick="G98 BB", Image="MauserGewehr98-f159616f.png" },
        new() { Guid="F59A978F-54BB-43F9-8497-47EC8D907EA6", Kind="RIFLE", Id="U_LeeEnfieldSMLE_Wep_Scope", Name="SMLE MKIII Marksman", Kick="MKIII SSS", Image="LeeEnfield-52626131.png" },
        new() { Guid="DB650ACE-7B44-4FA1-A146-EAE44E94C68C", Kind="RIFLE", Id="U_LeeEnfieldSMLE_Wep_Med", Name="SMLE MKIII Carbine", Kick="MKIII KBQ", Image="LeeEnfield-52626131.png" },
        new() { Guid="CD35EDD7-6F6E-4B72-ACC7-37CD0E4D060A", Kind="RIFLE", Id="U_LeeEnfieldSMLE", Name="SMLE MKIII Infantry", Kick="MKIII BB", Image="LeeEnfield-52626131.png" },
        new() { Guid="7ED7AE0D-03C6-44D4-9072-261C6570B3BF", Kind="RIFLE", Id="U_SteyrManM1895_Wep_Scope", Name="Gewehr M.95 Marksman", Kick="G95 SSS", Image="Mannlicher1895-7850a8ec.png" },
        new() { Guid="7668C6B5-D793-442A-8AFA-74E4CD158F33", Kind="RIFLE", Id="U_SteyrManM1895_Wep_Med", Name="Gewehr M.95 Carbine", Kick="G95 KBQ", Image="Mannlicher1895-7850a8ec.png" },
        new() { Guid="E372F592-9278-4777-A9E3-C91B171FD1F7", Kind="RIFLE", Id="U_SteyrManM1895", Name="Gewehr M.95 Infantry", Kick="G95 BB", Image="Mannlicher1895-7850a8ec.png" },
        new() { Guid="B0987D7E-F43D-4AA7-9A8E-A33EFA985864", Kind="RIFLE", Id="U_SpringfieldM1903_Wep_Scope", Name="M1903 Marksman", Kick="M1903 SSS", Image="SpringfieldM1903-c8ae5988.png" },
        new() { Guid="BA5E14FF-D373-4927-9D0F-11CD9423AE4B", Kind="RIFLE", Id="U_SpringfieldM1903_Wep_LongRange", Name="M1903 Sniper", Kick="M1903 JJS", Image="SpringfieldM1903-c8ae5988.png" },
        new() { Guid="9984202B-FE89-447C-879B-25A2B797A176", Kind="RIFLE", Id="U_SpringfieldM1903_Wep_Pedersen", Name="M1903 Experimental", Kick="M1903 SY", Image="SpringfieldM1903-c8ae5988.png" },
        new() { Guid="43E292F0-511B-458B-852A-7EBDB20F6B27", Kind="RIFLE", Id="U_MartiniHenry", Name="Martini Henry Infantry", Kick="MartiniHenry BB", Image="MartinHenry-c8477a11.png" },
        new() { Guid="0440A003-1E71-47A2-98A9-73EC23D83CB4", Kind="RIFLE", Id="U_MartiniHenry_Wep_LongRange", Name="Martini Henry Sniper", Kick="MartiniHenry JJS", Image="MartinHenry-c8477a11.png" },
        new() { Guid="1AC12662-F06E-4562-80A3-FFD598CEB7EB", Kind="RIFLE", Id="U_LeeEnfieldSMLE_Wep_Preorder", Name="Lawrence of Arabia's SMLE", Kick="SMLE LLS", Image="LeeEnfield-52626131.png" },
        new() { Guid="85EFAE4D-6C60-4DA0-8F38-0548E1FB193F", Kind="RIFLE", Id="U_Lebel1886_Wep_LongRange", Name="Lebel Model 1886 Sniper", Kick="M1886 JJS", Image="Lebel1886-31bf07f8.png" },
        new() { Guid="59D35CF4-3530-4B8C-9519-A78E9577BA1A", Kind="RIFLE", Id="U_Lebel1886", Name="Lebel Model  Infantry", Kick="M1886 BB", Image="Lebel1886-31bf07f8.png" },
        new() { Guid="FA55E980-2D48-4CFC-8700-1E0533C9CB4A", Kind="RIFLE", Id="U_MosinNagant1891", Name="Mosin-Nagant M91 Infantry", Kick="M91 BB", Image="MosinNagantM1891-fac2efac.png" },
        new() { Guid="9A1C2640-9684-414E-9D05-94F5A9858296", Kind="RIFLE", Id="U_MosinNagant1891_Wep_Scope", Name="Mosin-Nagant M91 Marksman", Kick="M91 SSS", Image="MosinNagantM1891-fac2efac.png" },
        new() { Guid="4A392B4B-97FA-4672-B5D8-C4085A87CB39", Kind="RIFLE", Id="U_MosinNagantM38", Name="Mosin-Nagant M38", Kick="M38 KBQ", Image="MosinNagantM38-dd529587.png" },
        new() { Guid="4B831597-5062-461E-9CC9-9611BD1B50E3", Kind="RIFLE", Id="U_VetterliVitaliM1870", Name="Vetterli-Vitali M1870/87 Infantry", Kick="M1870 BB", Image="Vetterli-VitaliM1870-87-faadf520.png" },
        new() { Guid="B6B5C8CB-0C40-4522-8907-4FCE5B243C83", Kind="RIFLE", Id="U_VetterliVitaliM1870_Wep_Med", Name="Vetterli-Vitali M1870/87 Carbine", Kick="M1870 KBQ", Image="Vetterli-VitaliM1870-87-faadf520.png" },
        new() { Guid="A3A708E8-6719-4178-9958-36814E906FD4", Kind="RIFLE", Id="U_Type38Arisaka", Name="Type 38 Arisaka Infantry", Kick="Type38 BB", Image="Type38Arisaka-a1c192e3.png" },
        new() { Guid="BB20B711-EF98-4708-998A-D78780B8B8C4", Kind="RIFLE", Id="U_Type38Arisaka_Wep_Scope", Name="Type 38 Arisaka Patrol", Kick="Type38 XL", Image="Type38Arisaka-a1c192e3.png" },
        new() { Guid="D0DBCD64-BFAE-4B96-867E-C493641C269B", Kind="RIFLE", Id="U_CarcanoCarbine", Name="Carcano M91 Carbine", Kick="M91 KBQ", Image="M1891CarcanoCarbine-cc7d34a1.png" },
        new() { Guid="4E317627-F7F8-4014-BB22-B0ABEB7E9141", Kind="RIFLE", Id="U_CarcanoCarbine_Wep_Scope", Name="Carcano M91 Patrol Carbine", Kick="M91 KBQ XL", Image="M1891CarcanoCarbine-cc7d34a1.png" },
        new() { Guid="8FAB67E1-A8ED-4EC0-8135-DB2BAA832890", Kind="RIFLE", Id="U_RossMkIII", Name="Ross MKIII Infantry", Kick="RossMkIII BB", Image="Ross_Mk3-f8900bf5.png" },
        new() { Guid="168D4F4B-AD76-40D3-AD86-EB52890872D8", Kind="RIFLE", Id="U_RossMkIII_Wep_Scope", Name="Ross MKIII Marksman", Kick="RossMkIII SSS", Image="Ross_Mk3-f8900bf5.png" },
        new() { Guid="D8F58A20-88D8-4C25-B395-385641324ACF", Kind="RIFLE", Id="U_Enfield1917", Name="M1917 Enfield Infantry", Kick="M1917 BB", Image="Enfield1917-d33fc14d.png" },
        new() { Guid="374F5969-7A06-4188-BA76-266F91304FE4", Kind="RIFLE", Id="U_Enfield1917_Wep_LongRange", Name="M1917 Enfield Silenced", Kick="M1917 XYQ", Image="Enfield1917-d33fc14d.png" },

        // Scout Sidearms
        new() { Guid="E5A72AA0-02C9-40B8-A74D-D60C921D1288", Kind="SIDEARM", Id="U_MarsAutoPistol", Name="Mars Automatic", Kick="MarsAutoPistol", Image="MarsAutoPistol-7f2606e9.png" },
        new() { Guid="F08BC756-2600-4834-BDBA-4E53C4A24E1D", Kind="SIDEARM", Id="U_Bodeo1889", Name="Bodeo 1889", Kick="Bodeo 1889", Image="Bodeo1889-a62282b6.png" },
        new() { Guid="FAE1EA24-DFBE-3E0A-E525-BC20340FE196", Kind="SIDEARM", Id="U_FrommerStop", Name="Frommer Stop", Kick="Frommer Stop", Image="FrommerStopAuto-ea5b918e.png" },

        // Scout Gadgets
        new() { Guid="2543311A-B9BC-4F72-8E71-C9D32DCA9CFC", Kind="GADGET", Id="U_FlareGun", Name="Flare Gun - Spot", Kick="Flare Gun ZC", Image="GadgetWebleyScottFlaregun-4438a413.png" },
        new() { Guid="ADAD5F72-BD74-46EF-AB42-99F95D88DF8E", Kind="GADGET", Id="U_FlareGun_Flash", Name="Flare Gun - Flash", Kick="Flare Gun SG", Image="GadgetWebleyScottFlaregunFlash-40b27cca.png" },
        new() { Guid="C43D1466-F9D1-474B-A737-3820B6989819", Kind="GADGET", Id="U_TrPeriscope", Name="Trench Periscope", Kick="Tr Periscope", Image="GadgetTrenchPeriscope-d916e58e.png" },
        new() { Guid="370323AD-6AFD-4D44-899E-7FB8144E580F", Kind="GADGET", Id="U_Shield", Name="Sniper Shield", Kick="Shield", Image="GadgetShield-9a6f10a4.png" },
        new() { Guid="C85A5030-C6DA-4DEF-8BA5-3087A80DEC17", Kind="GADGET", Id="U_HelmetDecoy", Name="Sniper Decoy", Kick="Helmet Decoy", Image="GadgetHelmetDecoy-182ae8c4.png" },
        new() { Guid="EF1C7B9B-8912-4298-8FCB-29CC75DD0E7F", Kind="GADGET", Id="U_TripWireBomb", Name="Tripwire Bomb - HE", Kick="Trip Wire Bomb", Image="GadgetTripWireGrenade-1618bbc3.png" },
        new() { Guid="033299D1-A8E6-4A5A-8932-6F2091745A9D", Kind="GADGET", Id="U_TripWireGas", Name="Tripwire Bomb - GAS", Kick="Trip Wire Gas", Image="GadgetTripWireBombGas-f1eabac0.png" },
        new() { Guid="9CF9EA1C-39A1-4365-85A1-3645B9621901", Kind="GADGET", Id="U_TripWireBurn", Name="Tripwire Bomb - INC", Kick="Trip Wire Burn", Image="TripWireBombINC-6a9a41fb.png" },
        new() { Guid="2D64B139-27C8-4EDB-AB14-734993A96008", Kind="GADGET", Id="_KBullet", Name="K Bullets", Kick="K Bullet", Image="GadgetKBullets-0ec1f92a.png" },

        /////////////////////////////////////////////////////////////////////////////

        // Kits
        new() { Guid="0B575357-B536-45FF-BC1B-386560AE2163", Kind="KIT", Id="U_MaximMG0815", Name="MG 08/15", Kick="Maxim MG0815", Image="Maxim0815-0879ffaa.png" },
        new() { Guid="BCF1DDDF-C812-43E6-9F5A-F08109BAB746", Kind="KIT", Id="U_VillarPerosa", Name="Villar Perosa", Kick="Villar Perosa", Image="VillarPerosa-4ba7d141.png" },
        new() { Guid="D4A1023A-6C3B-48DF-9515-C35A9463794D", Kind="KIT", Id="U_FlameThrower", Name="Wex", Kick="Wex", Image="WEXFlammenwerfer-13f2b3af.png" },
        new() { Guid="8219207A-41E6-4ED2-A3E8-9690752EC40C", Kind="KIT", Id="U_Incendiary_Hero", Name="Incendiary Hero", Kick="Incendiary Hero", Image="GadgetIncindiary-68d49a3a.png" },
        new() { Guid="8A849EDD-AE9F-4F9D-B872-7728067E4E9F", Kind="KIT", Id="U_RoyalClub", Name="Raider Club", Kick="Royal Club", Image="Steelclub-83b053cf.png" },
        new() { Guid="1B74E3E0-2484-3BF0-AF8F-25BFA008B6F0", Kind="KIT", Id="U_MartiniGrenadeLauncher", Name="Martini-Henry Grenade Launcher", Kick="Martini GL", Image="MartiniHenryGrenadeLauncher-65e27bf0.png" },
        new() { Guid="7085A5B9-6A77-4766-83CD-3666DA3EDF28", Kind="KIT", Id="U_SawnOffShotgun_FK", Name="Sawed Off Shotgun", Kick="SawnOffShotgun", Image="SawedOfShotgun-d31e0dd8.png" },
        new() { Guid="9D1BEE08-C101-4FF3-8ECA-244240171801", Kind="KIT", Id="U_FlareGun_Elite", Name="Flare Gun - Signal", Kick="FlareGun Elite", Image="GadgetWebleyScottFlaregunFlash-40b27cca.png" },
        new() { Guid="??????", Kind="KIT", Id="U_SpawnBeacon", Name="Spawn Beacon", Kick="Spawn Beacon", Image="GadgetHeliograph-66004cd6.png" },
        new() { Guid="A9DBBCBD-E028-4EE9-8123-252B983D8CD6", Kind="KIT", Id="U_TankGewehr", Name="Tankgewehr M1918", Kick="Tank Gewehr", Image="MauserTankgewehr1918-aedf4c56.png" },
        new() { Guid="C43D1466-F9D1-474B-A737-3820B6989819", Kind="KIT" , Id="U_TrPeriscope_Elite", Name="Trench Periscope Elite", Kick="Tr Periscope", Image="GadgetTrenchPeriscope-d916e58e.png" },
        new() { Guid="72CCBF3E-C0FE-4657-A1A7-EACDB2D11985", Kind="KIT", Id="U_ATGrenade_VhKit", Name="Anti-Tank Grenade", Kick="AT Grenade", Image="GadgetATGrenade-4b135d46.png" },

        ///////////////////////////////////////////////////////////////////////////////////

        // Offensive Ground Vehicles
        new() { Guid="4723A26F-98AE-55BA-7B3F-3AE7E0E3B0C7", Kind="LANDSHIP", Id="ID_P_VNAME_MARKV", Name="Mark V", Kick="Mark V", Image="GBRMarkV-bf3b1d1a.png" },
        new() { Guid="4723A26F-98AE-55BA-7B3F-3AE7E0E3B0C7", Kind="LANDSHIP", Id="U_GBR_MarkV_Package_Mortar", Name="Mark V Mortar", Kick="Mark V PJP", Image="GBRMarkV-bf3b1d1a.png" },
        new() { Guid="4723A26F-98AE-55BA-7B3F-3AE7E0E3B0C7", Kind="LANDSHIP", Id="U_GBR_MarkV_Package_AntiTank", Name="Mark V Tank Hunter", Kick="Mark V TKLS", Image="GBRMarkV-bf3b1d1a.png" },
        new() { Guid="4723A26F-98AE-55BA-7B3F-3AE7E0E3B0C7", Kind="LANDSHIP", Id="U_GBR_MarkV_Package_SquadSupport", Name="Mark V Squad Support", Kick="Mark V XDZY", Image="GBRMarkV-bf3b1d1a.png" },

        new() { Guid="4AA28E71-6FDA-A50B-80A8-B52D070FF884", Kind="HEAVY TANK", Id="ID_P_VNAME_A7V", Name="AV7", Kick="AV7", Image="GERA7V-bfc09237.png" },
        new() { Guid="4AA28E71-6FDA-A50B-80A8-B52D070FF884", Kind="HEAVY TANK", Id="U_GER_A7V_Package_Assault", Name="AV7 Assault", Kick="AV7 TJ", Image="GERA7V-bfc09237.png" },
        new() { Guid="4AA28E71-6FDA-A50B-80A8-B52D070FF884", Kind="HEAVY TANK", Id="U_GER_A7V_Package_Breakthrough", Name="AV7 Breakthroug", Kick="AV7 TP", Image="GERA7V-bfc09237.png" },
        new() { Guid="4AA28E71-6FDA-A50B-80A8-B52D070FF884", Kind="HEAVY TANK", Id="U_GER_A7V_Package_Flamethrower", Name="AV7 Flamethrower", Kick="AV7 HYPSQ", Image="GERA7V-bfc09237.png" },

        new() { Guid="A79071D2-5C4F-0BA8-0ECC-FCB1376E2FBA", Kind="LIGHT TANK", Id="ID_P_VNAME_FT17", Name="FT-17", Kick="FT-17", Image="FRARenaultFt-17-aea9e5e7.png" },
        new() { Guid="A79071D2-5C4F-0BA8-0ECC-FCB1376E2FBA", Kind="LIGHT TANK", Id="U_FRA_FT_Package_37mm", Name="FT-17 Close Support", Kick="FT-17 JJLZY", Image="FRARenaultFt-17-aea9e5e7.png" },
        new() { Guid="A79071D2-5C4F-0BA8-0ECC-FCB1376E2FBA", Kind="LIGHT TANK", Id="U_FRA_FT_Package_20mm", Name="FT-17 Flanker", Kick="FT-17 CYGJ", Image="FRARenaultFt-17-aea9e5e7.png" },
        new() { Guid="A79071D2-5C4F-0BA8-0ECC-FCB1376E2FBA", Kind="LIGHT TANK", Id="U_FRA_FT_Package_75mm", Name="FT-17 Howitzer", Kick="FT-17 LDP", Image="FRARenaultFt-17-aea9e5e7.png" },

        new() { Guid="A92386FB-7D4B-0E8A-6F2B-CC63FC2A8D78", Kind="ARMORED TRUCK", Id="ID_P_VNAME_ARTILLERYTRUCK", Name="Armored Truck", Kick="ARTILLERYTRUCK", Image="GBRPierceArrowAALorry-6e6d8d9f.png" },
        new() { Guid="A92386FB-7D4B-0E8A-6F2B-CC63FC2A8D78", Kind="ARMORED TRUCK", Id="U_GBR_PierceArrow_Package_Artillery", Name="Armored Truck Artillery", Kick="ATruck HP", Image="GBRPierceArrowAALorry-6e6d8d9f.png" },
        new() { Guid="A92386FB-7D4B-0E8A-6F2B-CC63FC2A8D78", Kind="ARMORED TRUCK", Id="U_GBR_PierceArrow_Package_AntiAircraft", Name="Armored Truck Anti Aircraft", Kick="ATruck AA", Image="GBRPierceArrowAALorry-6e6d8d9f.png" },
        new() { Guid="A92386FB-7D4B-0E8A-6F2B-CC63FC2A8D78", Kind="ARMORED TRUCK", Id="U_GBR_PierceArrow_Package_Mortar", Name="Armored Truck Mortar", Kick="ATruck Mortar", Image="GBRPierceArrowAALorry-6e6d8d9f.png" },

        new() { Guid="12F1002B-97FA-490B-822F-E621C6827BFB", Kind="ASSAULT TANK", Id="ID_P_VNAME_STCHAMOND", Name="St. Chamond", Kick="STCHAMOND", Image="FRAStChamond-3123e0cd.png" },
        new() { Guid="12F1002B-97FA-490B-822F-E621C6827BFB", Kind="ASSAULT TANK", Id="U_FRA_StChamond_Package_Assault", Name="St. Chamond Field", Kick="STCHAMOND ZD", Image="FRAStChamond-3123e0cd.png" },
        new() { Guid="12F1002B-97FA-490B-822F-E621C6827BFB", Kind="ASSAULT TANK", Id="U_FRA_StChamond_Package_Gas", Name="St. Chamond Gas", Kick="STCHAMOND DQ", Image="FRAStChamond-3123e0cd.png" },
        new() { Guid="12F1002B-97FA-490B-822F-E621C6827BFB", Kind="ASSAULT TANK", Id="U_FRA_StChamond_Package_Standoff", Name="St. Chamond Standoff", Kick="STCHAMOND DZ", Image="FRAStChamond-3123e0cd.png" },

        new() { Guid="705E9B4E-5E97-FD3C-9979-A4F2D11AE06F", Kind="ASSAULT TRUCK", Id="ID_P_VNAME_ASSAULTTRUCK", Name="Putilov Garford", Kick="ASSAULTTRUCK", Image="PutilovGarford-20a4fd91.png" },
        new() { Guid="705E9B4E-5E97-FD3C-9979-A4F2D11AE06F", Kind="ASSAULT TRUCK", Id="U_RU_PutilovGarford_Package_AssaultGun", Name="Putilov Garford Armored", Kick="ATTruck TX", Image="PutilovGarford-20a4fd91.png" },
        new() { Guid="705E9B4E-5E97-FD3C-9979-A4F2D11AE06F", Kind="ASSAULT TRUCK", Id="U_RU_PutilovGarford_Package_AntiVehicle", Name="Putilov Garford Anti-Tank", Kick="ATTruck AT", Image="PutilovGarford-20a4fd91.png" },
        new() { Guid="705E9B4E-5E97-FD3C-9979-A4F2D11AE06F", Kind="ASSAULT TRUCK", Id="U_RU_PutilovGarford_Package_Recon", Name="Putilov Garford Reconnaissance", Kick="ATTruck ZC", Image="PutilovGarford-20a4fd91.png" },

        ////////////////////////////////

        // Offensive Air Vehicles
        new() { Guid="EB79DB6E-8A05-9618-3368-34DCBE3C3C17", Kind="ATTACK PLANE", Id="ID_P_VNAME_HALBERSTADT", Name="CL.II", Kick="HALBERSTADT", Image="GERHalberstadtCLII-c1cb8257.png" },
        new() { Guid="33A894B8-BCE1-8689-3064-7308BBC781CC", Kind="ATTACK PLANE", Id="ID_P_VNAME_BRISTOL", Name="F2.B", Kick="BRISTOL", Image="GBRBristolF2B-141b8daa.png" },
        new() { Guid="189D43F5-E653-416B-B6D6-D0137C28375D", Kind="ATTACK PLANE", Id="ID_P_VNAME_SALMSON", Name="A.E.F 2-A2", Kick="SALMSON", Image="FRA_Salmson_2-05f47b5c.png" },
        new() { Guid="C3272C97-B92E-4E2A-B842-06EF06DC2CB0", Kind="ATTACK PLANE", Id="ID_P_VNAME_RUMPLER", Name="Rumpler C.I", Kick="RUMPLER", Image="AHU_Rumpler_CI-eb45a6be.png" },

        new() { Guid="??????", Kind="ATTACK PLANE", Id="U_2Seater_Package_GroundSupport", Name="Attack Plane Ground Support", Kick="2Seater DMZY", Image="AHU_Rumpler_CI-eb45a6be.png" },
        new() { Guid="??????", Kind="ATTACK PLANE", Id="U_2Seater_Package_TankHunter", Name="Attacl Plane Tank Hunter", Kick="2Seater TKLS", Image="AHU_Rumpler_CI-eb45a6be.png" },
        new() { Guid="??????", Kind="ATTACK PLANE", Id="U_2Seater_Package_AirshipBuster", Name="Attack Plane Airship Buster", Kick="2Seater FCHMZ", Image="AHU_Rumpler_CI-eb45a6be.png" },

        new() { Guid="2B0D6EA6-8978-6400-7E85-C8ED33E3B6B3", Kind="BOMBER", Id="ID_P_VNAME_GOTHA", Name="Gotha G.IV G", Kick="GOTHA", Image="GERGothaGIV-54bfb0bf.png" },
        new() { Guid="91ECED06-9066-470D-BFE0-A1122118A5B3", Kind="BOMBER", Id="ID_P_VNAME_CAPRONI", Name="Caproni CA.5", Kick="CAPRONI", Image="ITACaproniCa5-31fc77c8.png" },
        new() { Guid="DF87BA6E-961D-4F14-86B4-AE5F1326BA14", Kind="BOMBER", Id="ID_P_VNAME_DH10", Name="Airco DH.10", Kick="DH10", Image="GBR_Airco_DH10-05e772e8.png" },
        new() { Guid="887AA8B4-878C-4943-B688-BAE3E9A5A4E7", Kind="BOMBER", Id="ID_P_VNAME_HBG1", Name="Hansa Brandenburg G.I", Kick="HBG1", Image="AHU_Hansa_Brandenburg_GI-042fc3dc.png" },

        new() { Guid="??????", Kind="BOMBER", Id="U_Bomber_Package_Barrage", Name="Bomber Barrage", Kick="Bomber DM", Image="AHU_Hansa_Brandenburg_GI-042fc3dc.png" },
        new() { Guid="??????", Kind="BOMBER", Id="U_Bomber_Package_Firestorm", Name="Bomber Firestorm", Kick="Bomber YYFB", Image="AHU_Hansa_Brandenburg_GI-042fc3dc.png" },
        new() { Guid="??????", Kind="BOMBER", Id="U_Bomber_Package_Torpedo", Name="Bomber Torpedo", Kick="Bomber YL", Image="AHU_Hansa_Brandenburg_GI-042fc3dc.png" },

        new() { Guid="CB7D595C-0376-4C72-A8B8-1455965EA81E", Kind="FIGHTER", Id="ID_P_VNAME_SPAD", Name="SPAD S XIII", Kick="SPAD S XIII", Image="FRA_SPAD_X_XIII-8f60a194.png" },
        new() { Guid="ADF5B89F-5854-43C4-BAD4-46C9D1C020F5", Kind="FIGHTER", Id="ID_P_VNAME_SOPWITH", Name="Sopwith Camel", Kick="SOPWITH", Image="GBRSopwithCamel-39d664a3.png" },
        new() { Guid="AD78AD89-1824-B113-75EC-CFD3180A367D", Kind="FIGHTER", Id="ID_P_VNAME_DR1", Name="Fokker DR.1", Kick="DR1", Image="GERFokkerDR1-14f95745.png" },
        new() { Guid="6D6C110E-EBC9-42CC-BB7A-ACA156638D3C", Kind="FIGHTER", Id="ID_P_VNAME_ALBATROS", Name="Albatros D-III", Kick="ALBATROS", Image="GER_Albatros_DIII-5ca9e1d3.png" },

        new() { Guid="??????", Kind="FIGHTER", Id="U_Scout_Package_Dogfighter", Name="Fighter Dogfighter", Kick="Scout KZJ", Image="GER_Albatros_DIII-5ca9e1d3.png" },
        new() { Guid="??????", Kind="FIGHTER", Id="U_Scout_Package_BomberKiller", Name="Fighter Bobmer Killer", Kick="Scout HZJSS", Image="GER_Albatros_DIII-5ca9e1d3.png" },
        new() { Guid="??????", Kind="FIGHTER", Id="U_Scout_Package_TrenchFighter", Name="Fighter Trench Fighter", Kick="Scout ZHZDJ", Image="GER_Albatros_DIII-5ca9e1d3.png" },

        new() { Guid="E305E0C1-FED8-00FD-747A-C9282C51F524", Kind="HEAVY BOMBER", Id="ID_P_VNAME_ILYAMUROMETS", Name="Ilya Muromets", Kick="ILYAMUROMETS", Image="IlyaMurometsHeavyBomber-74779164.png" },

        new() { Guid="??????", Kind="HEAVY BOMBER", Id="U_HeavyBomber_Package_Strategic", Name="Ilya Muromets Strategic", Kick="HeavyBomber ZL", Image="IlyaMurometsHeavyBomber-74779164.png" },
        new() { Guid="??????", Kind="HEAVY BOMBER", Id="U_HeavyBomber_Package_Demolition", Name="Ilya Muromets Demolition", Kick="HeavyBomber BP", Image="IlyaMurometsHeavyBomber-74779164.png" },
        new() { Guid="??????", Kind="HEAVY BOMBER", Id="U_HeavyBomber_Package_Support", Name=" Ilya Muromets Support", Kick="HeavyBomber ZY", Image="IlyaMurometsHeavyBomber-74779164.png" },

        new() { Guid="4289E1A4-5EBE-7FA3-52D8-AFDB8ED374BA", Kind="AIRSHIP", Id="ID_P_VNAME_ASTRATORRES", Name="Class C Airship", Kick="ASTRATORRES", Image="AstraTorresAirship-e2148807.png" },

        new() { Guid="??????", Kind="AIRSHIP", Id="U_CoastalAirship_Package_Observation", Name="Class C Airship Observation", Kick="Airship GCZ", Image="AstraTorresAirship-e2148807.png" },
        new() { Guid="??????", Kind="AIRSHIP", Id="U_CoastalAirship_Package_Raider", Name="Class C Airship Raider", Kick="Airship NDZ", Image="AstraTorresAirship-e2148807.png" },
        
        ////////////////////////////////
        
        new() { Guid="67B44E81-D1DA-B485-D185-D6520CF59E4B", Kind="驱逐舰", Id="ID_P_VNAME_HMS_LANCE", Name="驱逐舰 L 级驱逐舰", Kick="HMS LANCE", Image="HMSLancerDestroyer-65317e44.png" },

        new() { Guid="??????", Kind="驱逐舰1", Id="U_HMS_Lance_Package_Destroyer", Name="鱼雷艇驱逐舰", Kick="HMS LANCE YL", Image="HMSLancerDestroyer-65317e44.png" },
        new() { Guid="??????", Kind="驱逐舰2", Id="U_HMS_Lance_Package_Minelayer", Name="水雷布设艇", Kick="HMS LANCE SL", Image="HMSLancerDestroyer-65317e44.png" },
        
        ////////////////////////////////
        // Animals
        new() { Guid="7CA00F5A-E5DE-3FD9-ECAD-7D4FC5C1AC80", Kind="ANIMAL", Id="ID_P_VNAME_HORSE", Name="Horse", Kick="HORSE", Image="Horse-c07830d0.png" },
        
        ////////////////////////////////
        // Cavalry
        new() { Guid="E76568C5-B222-4C49-B4E0-D517425596C6", Kind="CAVALRY", Id="U_WinchesterM1895_Horse", Name="Russian 1895", Kick="M1895 Horse", Image="Winchester1895-69d56c0b.png" },
        new() { Guid="52B19C38-72C0-4E0F-B051-EF11103F6220", Kind="CAVALRY", Id="U_AmmoPouch_Cav", Name="Ammo Pouch", Kick="Ammo Pouch", Image="GadgetSmallAmmoPack-5837fde5.png" },
        new() { Guid="9BCDB1F5-5E1C-4C3E-824C-8C05CC0CE21A", Kind="CAVALRY", Id="U_Bandages_Cav", Name="Med Puch", Kick="Bandage Pouch", Image="GadgetBandages-1d1fc900.png" },
        new() { Guid="D4A99456-2ABA-4376-9870-200FD24C5D45", Kind="CAVALRY", Id="U_Grenade_AT_Cavalry", Name="Light Anti-Tank Grenade", Kick="Grenade AT", Image="GadgetTrooperATGrenade-a6575030.png" },
        new() { Guid="009736C2-B237-49AE-9DD1-E77AF7771FF2", Kind="CAVALRY", Id="U_LugerP08_VhKit", Name="P08 Luger", Kick="LugerP08 VhKit", Image="LugerP08-7f07aa2d.png" },
        
        ////////////////////////////////
        // Mortars
        new() { Guid="C71A02C3-608E-42AA-9179-A4324A4D4539", Kind="GADGET", Id="ID_P_INAME_U_MORTAR", Name="Mortar -  AIR", Kick="MORTAR", Image="MortarAirburst-77c9647f.png" },
        new() { Guid="8BD0FABD-DCCE-4031-8156-B77866FCE1A0", Kind="GADGET", Id="ID_P_INAME_MORTAR_HE", Name="Mortar - HE", Kick="MORTAR HE", Image="GadgetMortar-84e30045.png" },
            
        /////////////////////////////////////////////////////////////////////////////

        // 运输载具        
        new() { Guid="1F37F90F-F85E-A4EA-0CA0-977FBC04DB6C", Kind="运输载具", Id="ID_P_VNAME_MODEL30", Name="运输载具 M30 侦察车", Kick="MODEL30", Image="USADodgeScoutCar-843c9c16.png" },
        new() { Guid="A9D9062B-FFEC-429E-9DD5-E24EB9D9C51B", Kind="运输载具", Id="ID_P_VNAME_MERCEDES_37", Name="运输载具 37/95 侦察车", Kick="MERCEDES 37", Image="AHU_Mercedes_37_95-69b407d2.png" },
        new() { Guid="F73DA041-0864-4782-BEDD-D9C08D86DA7D", Kind="运输载具", Id="ID_P_VNAME_BENZ_MG", Name="运输载具 KFT 侦察车", Kick="BENZ MG", Image="GER_Benz_MGCarrier-474daf7b.png" },
        new() { Guid="56C8EC6A-6667-547E-8393-B047A1BCB730", Kind="运输载具", Id="ID_P_VNAME_MOTORCYCLE", Name="运输载具 MC 18J 附边车摩托车", Kick="MOTORCYCLE", Image="USAHarleyDavidsson18J-27b0d7ef.png" },
        new() { Guid="41A7B28A-FE39-4FC8-9AA3-9AD7BC4F6A3C", Kind="运输载具", Id="ID_P_VNAME_NSU", Name="运输载具 MC 3.5HP  附边车摩托车", Kick="NSU", Image="GER_NSU_1914-e1a63515.png" },
        new() { Guid="7FEDA17B-6A27-1946-A02E-AA72A72FBCD7", Kind="运输载具", Id="ID_P_VNAME_ROLLS", Name="运输载具 RNAS 装甲车", Kick="ROLLS", Image="GBRRollsRoyceArmoredCar-4c6ccdf0.png" },
        new() { Guid="045085BF-D9E2-476F-9363-C11DD9BDDC61", Kind="运输载具", Id="ID_P_VNAME_ROMFELL", Name="运输载具 Romfell 装甲车", Kick="ROMFELL", Image="GER_Romfell-79d5be52.png" },
        new() { Guid="B30F9312-6887-46C5-873F-2670906856AE", Kind="运输载具", Id="ID_P_VNAME_EHRHARDT", Name="运输载具 EV4 装甲车", Kick="EHRHARDT", Image="GER_Ehrhardt_EV4-1e718572.png" },
        new() { Guid="87E38FC3-022D-4A88-80B5-6E3BD58C320F", Kind="运输载具", Id="ID_P_VNAME_TERNI", Name="运输载具 F.T. 装甲车", Kick="TERNI", Image="ITA_Fiat_Terni-3d8076d6.png" },
        new() { Guid="FA740EE6-6C1E-2F97-D48B-0EF8D1C7D11B", Kind="运输载具", Id="ID_P_VNAME_MAS15", Name="运输载具 M.A.S 鱼雷快艇", Kick="MAS15", Image="ITAMAS-51e28b0e.png" },
        new() { Guid="EA1C556F-DC5A-4764-BE8F-E661AF2B2C3B", Kind="运输载具", Id="ID_P_VNAME_YLIGHTER", Name="运输载具 Y-Lighter 登陆艇", Kick="MAS15", Image="GBR_Y_Lighter-468f2eaa.png" },
        
        /////////////////////////////////////////////////////////////////////////////

        // 定点武器
        new() { Guid="E7825334-17D9-3BA1-D59C-8497155B8DBB", Kind="定点武器", Id="ID_P_VNAME_FIELDGUN", Name="定点武器 FK 96 野战炮", Kick="FIELDGUN", Image="GERFk96nA-760d0461.png" },
        new() { Guid="12689F49-C72C-6BFE-07E9-A26258C0FCA0", Kind="定点武器", Id="ID_P_VNAME_TURRET", Name="定点武器 堡垒火炮", Kick="TURRET", Image="FRAFortressTurret-9fb165ad.png" },
        new() { Guid="2E5402EF-6303-B756-AEE9-E7926AB5FEF8", Kind="定点武器", Id="ID_P_VNAME_AASTATION", Name="定点武器 QF 1 防空炮", Kick="AASTATION", Image="GBRQF1-63882f78.png" },
        new() { Guid="690ABB5C-7B7E-4609-B37A-2DB46C2F6287", Kind="定点武器", Id="ID_P_INAME_MAXIM", Name="定点武器 重型机枪", Kick="MAXIM", Image="GBRVickers-ea4826ae.png" },
        // A3C6FC16-2DF6-4719-9A5F-E079CDB928F3 定点武器 高爆机炮 GER_BeckerM_Stationary-c741a373.png
        new() { Guid="EFB07B81-BBA3-413E-AF40-221CC104C21D", Kind="定点武器", Id="ID_P_VNAME_BL9", Name="定点武器 BL 9.2 攻城炮", Kick="BL9", Image="GBRBL9-0a10176d.png" },
        new() { Guid="B3BFBF74-6475-598C-C097-06DA0375F14A", Kind="定点武器", Id="ID_P_VNAME_COASTALBATTERY", Name="定点武器 350/52 o 岸防炮", Kick="COASTALBATTERY", Image="DagoCoastalArtilleryGun-b4b737b1.png" },
        new() { Guid="??????", Kind="定点武器", Id="ID_P_VNAME_SK45GUN", Name="定点武器 SK45 岸防炮", Kick="SK45GUN", Image="" },
        
        /////////////////////////////////////////////////////////////////////////////
        
        // 战争巨兽
        new() { Guid="1A7DEECF-4F0E-E343-9644-D6D91DCAEC12", Kind="机械巨兽", Id="ID_P_VNAME_ZEPPELIN", Name="机械巨兽 飞船 l30", Kick="ZEPPELIN", Image="GERZeppelinL30-62618731.png" },
        new() { Guid="A3ED808E-1525-412B-8E77-9EB6902A55D2", Kind="机械巨兽", Id="ID_P_VNAME_ARMOREDTRAIN", Name="机械巨兽 装甲列车", Kick="ARMOREDTRAIN", Image="RUSArmoredTrain-564a4e48.png" },
        new() { Guid="003FCC0A-2758-8508-4774-78E66FA1B5E3", Kind="机械巨兽", Id="ID_P_VNAME_IRONDUKE", Name="机械巨兽 无畏舰", Kick="IRONDUKE", Image="GBRHMSIronDuke-3b82016f.png" },
        new() { Guid="BBFC5A91-B2FC-48D2-8913-658C08072E6E", Kind="机械巨兽", Id="ID_P_VNAME_CHAR", Name="机械巨兽 Char 2C", Kick="CHAR", Image="FRAChar2C-b8f3c0e2.png" },
        
        /////////////////////////////////////////////////////////////////////////////
        
        // 近战
        new() { Guid="E0F9C0D2-939A-4E89-AA8B-B3AF5ADA5C86", Kind="近战武器", Id="U_GrenadeClub", Name="哑弹棒", Kick="Grenade Club", Image="" },
        new() { Guid="5ECF98B5-035C-4D9E-99DA-0B5802E343B6", Kind="近战武器", Id="U_Club", Name="棍棒", Kick="Club", Image="" },
        
        // 其他
        new() { Guid="??????", Kind="MASK", Id="U_GasMask", Name="Gas Mask", Kick="Gas Mask", Image="" },
    };
}

public class WeaponInfo
{
    public string Guid;
    public string Kind;
    public string Id;
    public string Name;
    public string Kick;
    public string Image;

    public string GetWeaponImage()
    {
        return string.IsNullOrEmpty(Image) ? string.Empty : ClientUtil.GetHostImageURL($"Weapons\\{Image}");
    }

    public string GetWeapon2Image()
    {
        return string.IsNullOrEmpty(Image) ? string.Empty : ClientUtil.GetHostImageURL($"Weapons2\\{Image}");
    }
}