using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class ContractData
    {

        // Afghanistan
        public class ContractData_Afghanistan
        {
            public class WorkerContractData
            {
                public string? Tazkira { get; set; }
                public static readonly string Tazkira_LocalName = "تذکره";

                public string? JawazSafar { get; set; }
                public static readonly string JawazSafar_LocalName = "جواز سفر";
                public DateTime? JawazSafar_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TIN { get; set; }
                public static readonly string TIN_LocalName = "شماره مالیاتی";
                public DateTime? TIN_ExpirationDate { get; set; }
            }
        }

        // Albania
        public class ContractData_Albania
        {
            public class WorkerContractData
            {
                public string? NumriIdentifikimit { get; set; }
                public static readonly string NumriIdentifikimit_LocalName = "Numri i Identifikimit";
                public DateTime? NumriIdentifikimit_ExpirationDate { get; set; }

                public string? Pasaport { get; set; }
                public static readonly string Pasaport_LocalName = "Numri i Pasaportës";
                public DateTime? Pasaport_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? NIPT { get; set; }
                public static readonly string NIPT_LocalName = "Numri i Identifikimit të Personit Të Drejtësisë";
            }
        }

        // Algeria
        public class ContractData_Algeria
        {
            public class WorkerContractData
            {
                public string? NuméroIdentifiantNational { get; set; }
                public static readonly string NuméroIdentifiantNational_LocalName = "Numéro d'Identifiant National";
                public DateTime? NuméroIdentifiantNational_ExpirationDate { get; set; }

                public string? Passeport { get; set; }
                public static readonly string Passeport_LocalName = "Numéro de Passeport";
                public DateTime? Passeport_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? NIF { get; set; }
                public static readonly string NIF_LocalName = "Numéro d'Identification Fiscale";
            }
        }

        // Argentina
        public class ContractData_Argentina
        {
            public class WorkerContractData
            {
                public string? DNI { get; set; }
                public static readonly string DNI_LocalName = "DNI";
                public DateTime? DNI_ExpirationDate { get; set; }

                public string? CUIL { get; set; }
                public static readonly string CUIL_LocalName = "CUIL";
                public DateTime? CUIL_ExpirationDate { get; set; }

                public string? Passaporte { get; set; }
                public static readonly string Passaporte_LocalName = "Número de Pasaporte";
                public DateTime? Passaporte_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? CUIT { get; set; }
                public static readonly string CUIT_LocalName = "CUIT";
            }
        }

        // Armenia
        public class ContractData_Armenia
        {
            public class WorkerContractData
            {
                public string? AncanavorHamazgayinHamapatasxanHamar { get; set; }
                public static readonly string AncanavorHamazgayinHamapatasxanHamar_LocalName = "Անձնագրի համար";
                public DateTime? AncanavorHamazgayinHamapatasxanHamar_ExpirationDate { get; set; }

                public string? HandznarakirPasport { get; set; }
                public static readonly string HandznarakirPasport_LocalName = "Ձեռք բերված անձնագիր";
                public DateTime? HandznarakirPasport_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxNumber { get; set; }
                public static readonly string TaxNumber_LocalName = "Հարկային կոդ";
            }
        }

        // Australia
        public class ContractData_Australia
        {
            public class WorkerContractData
            {
                public string? TFN { get; set; }
                public static readonly string TFN_LocalName = "Tax File Number";
                public DateTime? TFN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? ABN { get; set; }
                public static readonly string ABN_LocalName = "Australian Business Number";
            }
        }

        // Austria
        public class ContractData_Austria
        {
            public class WorkerContractData
            {
                public string? Staatsbürgerschaftsnr { get; set; }
                public static readonly string Staatsbürgerschaftsnr_LocalName = "Staatsbürgerschaftsnr";
                public DateTime? Staatsbürgerschaftsnr_ExpirationDate { get; set; }

                public string? Reisepassnummer { get; set; }
                public static readonly string Reisepassnummer_LocalName = "Reisepassnummer";
                public DateTime? Reisepassnummer_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "Umsatzsteuer-Identifikationsnummer";
            }
        }

        // Azerbaijan
        public class ContractData_Azerbaijan
        {
            public class WorkerContractData
            {
                public string? ŞəxsiyyətVəsiqəsi { get; set; }
                public static readonly string ŞəxsiyyətVəsiqəsi_LocalName = "Şəxsiyyət Vəsiqəsi";
                public DateTime? ŞəxsiyyətVəsiqəsi_ExpirationDate { get; set; }

                public string? Pasport { get; set; }
                public static readonly string Pasport_LocalName = "Pasport";
                public DateTime? Pasport_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TIN { get; set; }
                public static readonly string TIN_LocalName = "Vergi İdentifikasiya Nömrəsi";
            }
        }

        // Bahamas
        public class ContractData_Bahamas
        {
            public class WorkerContractData
            {
                public string? NIB { get; set; }
                public static readonly string NIB_LocalName = "National Insurance Board Number";
                public DateTime? NIB_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxNumber { get; set; }
                public static readonly string TaxNumber_LocalName = "Tax Identification Number";
            }
        }

        // Bahrain
        public class ContractData_Bahrain
        {
            public class WorkerContractData
            {
                public string? NationalID { get; set; }
                public static readonly string NationalID_LocalName = "National ID";
                public DateTime? NationalID_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? CRNumber { get; set; }
                public static readonly string CRNumber_LocalName = "Commercial Registration Number";
            }
        }

        // Bangladesh
        public class ContractData_Bangladesh
        {
            public class WorkerContractData
            {
                public string? NID { get; set; }
                public static readonly string NID_LocalName = "National ID";
                public DateTime? NID_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TIN { get; set; }
                public static readonly string TIN_LocalName = "Tax Identification Number";
            }
        }

        // Barbados
        public class ContractData_Barbados
        {
            public class WorkerContractData
            {
                public string? NIS { get; set; }
                public static readonly string NIS_LocalName = "National Insurance Number";
                public DateTime? NIS_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? BR { get; set; }
                public static readonly string BR_LocalName = "Business Registration Number";
            }
        }

        // Belarus
        public class ContractData_Belarus
        {
            public class WorkerContractData
            {
                public string? PASSPORT { get; set; }
                public static readonly string PASSPORT_LocalName = "Паспорт";
                public DateTime? PASSPORT_ExpirationDate { get; set; }

                public string? IDN { get; set; }
                public static readonly string IDN_LocalName = "Идентификационный номер";
                public DateTime? IDN_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TIN { get; set; }
                public static readonly string TIN_LocalName = "Идентификационный номер налогоплательщика";
            }
        }

        // Belgium
        public class ContractData_Belgium
        {
            public class WorkerContractData
            {
                public string? NationalNumber { get; set; }
                public static readonly string NationalNumber_LocalName = "Numéro de Registre National";
                public DateTime? NationalNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de Passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "Numéro de TVA";
            }
        }

        // Belize
        public class ContractData_Belize
        {
            public class WorkerContractData
            {
                public string? SocialSecurityNumber { get; set; }
                public static readonly string SocialSecurityNumber_LocalName = "Social Security Number";
                public DateTime? SocialSecurityNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxNumber { get; set; }
                public static readonly string TaxNumber_LocalName = "Tax Identification Number";
            }
        }

        // Benin
        public class ContractData_Benin
        {
            public class WorkerContractData
            {
                public string? NuméroCNI { get; set; }
                public static readonly string NuméroCNI_LocalName = "Numéro de la Carte Nationale d'Identité";
                public DateTime? NuméroCNI_ExpirationDate { get; set; }

                public string? NuméroPasseport { get; set; }
                public static readonly string NuméroPasseport_LocalName = "Numéro de Passeport";
                public DateTime? NuméroPasseport_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxIdentificationNumber { get; set; }
                public static readonly string TaxIdentificationNumber_LocalName = "Numéro d'Identification Fiscale";
            }
        }

        // Bhutan
        public class ContractData_Bhutan
        {
            public class WorkerContractData
            {
                public string? CID { get; set; }
                public static readonly string CID_LocalName = "Citizen ID";
                public DateTime? CID_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TIN { get; set; }
                public static readonly string TIN_LocalName = "Tax Identification Number";
            }
        }

        // Bolivia
        public class ContractData_Bolivia
        {
            public class WorkerContractData
            {
                public string? CI { get; set; }
                public static readonly string CI_LocalName = "Cédula de Identidad";
                public DateTime? CI_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de Pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? NIT { get; set; }
                public static readonly string NIT_LocalName = "Número de Identificación Tributaria";
            }
        }

        // Bosnia and Herzegovina
        public class ContractData_BosniaAndHerzegovina
        {
            public class WorkerContractData
            {
                public string? JMBG { get; set; }
                public static readonly string JMBG_LocalName = "Jedinstveni Matični Broj Građana";
                public DateTime? JMBG_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Broj Pasoša";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? PIB { get; set; }
                public static readonly string PIB_LocalName = "Poreski Identifikacioni Broj";
            }
        }

        // Botswana
        public class ContractData_Botswana
        {
            public class WorkerContractData
            {
                public string? NationalID { get; set; }
                public static readonly string NationalID_LocalName = "National ID Number";
                public DateTime? NationalID_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TIN { get; set; }
                public static readonly string TIN_LocalName = "Tax Identification Number";
            }
        }

        // Brazil
        public class ContractData_Brazil
        {
            public class WorkerContractData
            {
                public string? CPF { get; set; }
                public static readonly string CPF_LocalName = "Cadastro de Pessoas Físicas";
                public DateTime? CPF_ExpirationDate { get; set; }

                public string? RG { get; set; }
                public static readonly string RG_LocalName = "Registro Geral";
                public DateTime? RG_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de Passaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? CNPJ { get; set; }
                public static readonly string CNPJ_LocalName = "Cadastro Nacional da Pessoa Jurídica";
            }
        }

        // Brunei
        public class ContractData_Brunei
        {
            public class WorkerContractData
            {
                public string? NationalID { get; set; }
                public static readonly string NationalID_LocalName = "National Identity Card";
                public DateTime? NationalID_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? GSTNumber { get; set; }
                public static readonly string GSTNumber_LocalName = "Goods and Services Tax Number";
            }
        }

        // Bulgaria
        public class ContractData_Bulgaria
        {
            public class WorkerContractData
            {
                public string? EGN { get; set; }
                public static readonly string EGN_LocalName = "ЕГН (Единен граждански номер)";
                public DateTime? EGN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Номер на паспорт";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "Данъчен номер";
            }
        }

        // Burkina Faso
        public class ContractData_BurkinaFaso
        {
            public class WorkerContractData
            {
                public string? NINA { get; set; }
                public static readonly string NINA_LocalName = "Numéro d'Identification Nationale";
                public DateTime? NINA_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de Passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Identifiant Fiscal";
            }
        }

        // Burundi
        public class ContractData_Burundi
        {
            public class WorkerContractData
            {
                public string? NID { get; set; }
                public static readonly string NID_LocalName = "Numéro d'Identification";
                public DateTime? NID_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de Passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'Identification Fiscale";
            }
        }

        // Cambodia
        public class ContractData_Cambodia
        {
            public class WorkerContractData
            {
                public string? NationalID { get; set; }
                public static readonly string NationalID_LocalName = "National Identification Number";
                public DateTime? NationalID_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Cameroon
        public class ContractData_Cameroon
        {
            public class WorkerContractData
            {
                public string? NationalID { get; set; }
                public static readonly string NationalID_LocalName = "Numéro d'Identification Nationale";
                public DateTime? NationalID_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de Passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'Identification Fiscale";
            }
        }

        // Canada
        public class ContractData_Canada
        {
            public class WorkerContractData
            {
                public string? SIN { get; set; }
                public static readonly string SIN_LocalName = "Social Insurance Number";
                public DateTime? SIN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? BN { get; set; }
                public static readonly string BN_LocalName = "Business Number";
            }
        }

        // Central African Republic
        public class ContractData_CentralAfricanRepublic
        {
            public class WorkerContractData
            {
                public string? NationalID { get; set; }
                public static readonly string NationalID_LocalName = "Numéro d'Identification Nationale";
                public DateTime? NationalID_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de Passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'Identification Fiscale";
            }
        }

        // Chad
        public class ContractData_Chad
        {
            public class WorkerContractData
            {
                public string? NIN { get; set; }
                public static readonly string NIN_LocalName = "Numéro d'Identification Nationale";
                public DateTime? NIN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de Passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'Identification Fiscale";
            }
        }

        // Chile
        public class ContractData_Chile
        {
            public class WorkerContractData
            {
                public string? RUN { get; set; }
                public static readonly string RUN_LocalName = "RUT/RUN";
                public DateTime? RUN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de Pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? RUT { get; set; }
                public static readonly string RUT_LocalName = "Rol Único Tributario";
            }
        }

        // China
        public class ContractData_China
        {
            public class WorkerContractData
            {
                public string? IDCard { get; set; }
                public static readonly string IDCard_LocalName = "居民身份证";
                public DateTime? IDCard_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "护照";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "税务登记号";
            }
        }

        // Colombia
        public class ContractData_Colombia
        {
            public class WorkerContractData
            {
                public string? CC { get; set; }
                public static readonly string CC_LocalName = "Cédula de Ciudadanía";
                public DateTime? CC_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de Pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? NIT { get; set; }
                public static readonly string NIT_LocalName = "Número de Identificación Tributaria";
            }
        }

        // Comoros
        public class ContractData_Comoros
        {
            public class WorkerContractData
            {
                public string? NIN { get; set; }
                public static readonly string NIN_LocalName = "Numéro d'Identification Nationale";
                public DateTime? NIN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de Passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'Identification Fiscale";
            }
        }

        // Congo, Republic of the
        public class ContractData_CongoRepublic
        {
            public class WorkerContractData
            {
                public string? NIN { get; set; }
                public static readonly string NIN_LocalName = "Numéro d'Identification Nationale";
                public DateTime? NIN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de Passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'Identification Fiscale";
            }
        }

        // Congo, Democratic Republic of the
        public class ContractData_CongoDemocraticRepublic
        {
            public class WorkerContractData
            {
                public string? NIN { get; set; }
                public static readonly string NIN_LocalName = "Numéro d'Identification Nationale";
                public DateTime? NIN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de Passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'Identification Fiscale";
            }
        }

        // Costa Rica
        public class ContractData_CostaRica
        {
            public class WorkerContractData
            {
                public string? DIMEX { get; set; }
                public static readonly string DIMEX_LocalName = "Documento de Identidad para Extranjeros";
                public DateTime? DIMEX_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de Pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? NIT { get; set; }
                public static readonly string NIT_LocalName = "Número de Identificación Tributaria";
            }
        }

        // Croatia
        public class ContractData_Croatia
        {
            public class WorkerContractData
            {
                public string? OIB { get; set; }
                public static readonly string OIB_LocalName = "Osobni identifikacijski broj";
                public DateTime? OIB_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Broj putovnice";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "OIB";
            }
        }

        // Cuba
        public class ContractData_Cuba
        {
            public class WorkerContractData
            {
                public string? DNI { get; set; }
                public static readonly string DNI_LocalName = "Documento Nacional de Identidad";
                public DateTime? DNI_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de Pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? NIT { get; set; }
                public static readonly string NIT_LocalName = "Número de Identificación Tributaria";
            }
        }

        // Cyprus
        public class ContractData_Cyprus
        {
            public class WorkerContractData
            {
                public string? IDCard { get; set; }
                public static readonly string IDCard_LocalName = "Αριθμός Ταυτότητας";
                public DateTime? IDCard_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Αριθμός Διαβατηρίου";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "Αριθμός ΦΠΑ";
            }
        }

        // Czechia
        public class ContractData_Czechia
        {
            public class WorkerContractData
            {
                public string? RC { get; set; }
                public static readonly string RC_LocalName = "Rodné číslo";
                public DateTime? RC_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Číslo pasu";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "DIČ";
            }
        }

        // Denmark
        public class ContractData_Denmark
        {
            public class WorkerContractData
            {
                public string? CPR { get; set; }
                public static readonly string CPR_LocalName = "CPR-nummer";
                public DateTime? CPR_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Pasnummer";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? CVR { get; set; }
                public static readonly string CVR_LocalName = "CVR-nummer";
            }
        }

        // Djibouti
        public class ContractData_Djibouti
        {
            public class WorkerContractData
            {
                public string? NIN { get; set; }
                public static readonly string NIN_LocalName = "Numéro d'Identification Nationale";
                public DateTime? NIN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de Passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'Identification Fiscale";
            }
        }

        // Dominica
        public class ContractData_Dominica
        {
            public class WorkerContractData
            {
                public string? NID { get; set; }
                public static readonly string NID_LocalName = "Numéro d'Identification Nationale";
                public DateTime? NID_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de Passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'Identification Fiscale";
            }
        }

        // Dominican Republic
        public class ContractData_DominicanRepublic
        {
            public class WorkerContractData
            {
                public string? CI { get; set; }
                public static readonly string CI_LocalName = "Cédula de Identidad";
                public DateTime? CI_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de Pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? RNC { get; set; }
                public static readonly string RNC_LocalName = "Registro Nacional de Contribuyentes";
            }
        }

        // Ecuador
        public class ContractData_Ecuador
        {
            public class WorkerContractData
            {
                public string? CI { get; set; }
                public static readonly string CI_LocalName = "Cédula de Identidad";
                public DateTime? CI_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de Pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? RUC { get; set; }
                public static readonly string RUC_LocalName = "Registro Único de Contribuyentes";
            }
        }

        // Egypt
        public class ContractData_Egypt
        {
            public class WorkerContractData
            {
                public string? NID { get; set; }
                public static readonly string NID_LocalName = "رقم قومي";
                public DateTime? NID_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "رقم جواز السفر";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "رقم التعريف الضريبي";
            }
        }

        // El Salvador
        public class ContractData_ElSalvador
        {
            public class WorkerContractData
            {
                public string? NIT { get; set; }
                public static readonly string NIT_LocalName = "Número de Identificación Tributaria";
                public DateTime? NIT_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de Pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? NITCompany { get; set; }
                public static readonly string NITCompany_LocalName = "Número de Identificación Tributaria de la Empresa";
            }
        }

        // Equatorial Guinea
        public class ContractData_EquatorialGuinea
        {
            public class WorkerContractData
            {
                public string? NIN { get; set; }
                public static readonly string NIN_LocalName = "Numéro d'Identification Nationale";
                public DateTime? NIN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de Passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'Identification Fiscale";
            }
        }

        // Eritrea
        public class ContractData_Eritrea
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "የህዝብ መለያ ቁጥር";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "የውጭ ዳታ ወኪል";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "የግብር መለያ ቁጥር";
            }
        }

        // Estonia
        public class ContractData_Estonia
        {
            public class WorkerContractData
            {
                public string? IDCode { get; set; }
                public static readonly string IDCode_LocalName = "Isikukood";
                public DateTime? IDCode_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passi number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Maksukohustuslase number";
            }
        }

        // Eswatini
        public class ContractData_Eswatini
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Identification Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Ethiopia
        public class ContractData_Ethiopia
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Identification Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Fiji
        public class ContractData_Fiji
        {
            public class WorkerContractData
            {
                public string? NIN { get; set; }
                public static readonly string NIN_LocalName = "National Identification Number";
                public DateTime? NIN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Finland
        public class ContractData_Finland
        {
            public class WorkerContractData
            {
                public string? SSN { get; set; }
                public static readonly string SSN_LocalName = "Henkilötunnus";
                public DateTime? SSN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passin numero";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "ALV-tunnus";
            }
        }

        // France
        public class ContractData_France
        {
            public class WorkerContractData
            {
                public string? INE { get; set; }
                public static readonly string INE_LocalName = "Identifiant National Élève";
                public DateTime? INE_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de Passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "Numéro de TVA";
            }
        }

        // Gabon
        public class ContractData_Gabon
        {
            public class WorkerContractData
            {
                public string? NIN { get; set; }
                public static readonly string NIN_LocalName = "Numéro d'Identification Nationale";
                public DateTime? NIN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de Passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'Identification Fiscale";
            }
        }

        // Gambia
        public class ContractData_Gambia
        {
            public class WorkerContractData
            {
                public string? NIN { get; set; }
                public static readonly string NIN_LocalName = "National Identification Number";
                public DateTime? NIN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Georgia
        public class ContractData_Georgia
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Germany
        public class ContractData_Germany
        {
            public class WorkerContractData
            {
                public string? SSN { get; set; }
                public static readonly string SSN_LocalName = "Sozialversicherungsnummer";
                public DateTime? SSN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Reisepassnummer";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "USt-IdNr.";
            }
        }

        // Ghana
        public class ContractData_Ghana
        {
            public class WorkerContractData
            {
                public string? Ghanacard { get; set; }
                public static readonly string Ghanacard_LocalName = "Ghanacard Number";
                public DateTime? Ghanacard_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Greece
        public class ContractData_Greece
        {
            public class WorkerContractData
            {
                public string? AMKA { get; set; }
                public static readonly string AMKA_LocalName = "Αριθμός Μητρώου Κοινωνικής Ασφάλισης";
                public DateTime? AMKA_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Αριθμός Διαβατηρίου";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "Αριθμός ΦΠΑ";
            }
        }

        // Grenada
        public class ContractData_Grenada
        {
            public class WorkerContractData
            {
                public string? NID { get; set; }
                public static readonly string NID_LocalName = "National Identification Number";
                public DateTime? NID_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Guatemala
        public class ContractData_Guatemala
        {
            public class WorkerContractData
            {
                public string? NIT { get; set; }
                public static readonly string NIT_LocalName = "Número de Identificación Tributaria";
                public DateTime? NIT_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de Pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? NITCompany { get; set; }
                public static readonly string NITCompany_LocalName = "Número de Identificación Tributaria de la Empresa";
            }
        }

        // Guinea
        public class ContractData_Guinea
        {
            public class WorkerContractData
            {
                public string? NIN { get; set; }
                public static readonly string NIN_LocalName = "Numéro d'Identification Nationale";
                public DateTime? NIN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de Passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'Identification Fiscale";
            }
        }

        // Guinea-Bissau
        public class ContractData_GuineaBissau
        {
            public class WorkerContractData
            {
                public string? NID { get; set; }
                public static readonly string NID_LocalName = "Número de Identificação Nacional";
                public DateTime? NID_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de Passaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Número de Identificação Fiscal";
            }
        }

        // Guyana
        public class ContractData_Guyana
        {
            public class WorkerContractData
            {
                public string? NID { get; set; }
                public static readonly string NID_LocalName = "National Identification Number";
                public DateTime? NID_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Haiti
        public class ContractData_Haiti
        {
            public class WorkerContractData
            {
                public string? NID { get; set; }
                public static readonly string NID_LocalName = "Numéro d'Identification Nationale";
                public DateTime? NID_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de Passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'Identification Fiscale";
            }
        }

        // Honduras
        public class ContractData_Honduras
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Número de Identificación";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de Pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? RNC { get; set; }
                public static readonly string RNC_LocalName = "Registro Nacional de Contribuyentes";
            }
        }

        // Hungary
        public class ContractData_Hungary
        {
            public class WorkerContractData
            {
                public string? TaxNumber { get; set; }
                public static readonly string TaxNumber_LocalName = "Adószám";
                public DateTime? TaxNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Útlevélszám";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "ÁFA szám";
            }
        }

        // Iceland
        public class ContractData_Iceland
        {
            public class WorkerContractData
            {
                public string? SSN { get; set; }
                public static readonly string SSN_LocalName = "Kennitala";
                public DateTime? SSN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Pasaportanúmer";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "VSK númer";
            }
        }

        // India
        public class ContractData_India
        {
            public class WorkerContractData
            {
                public string? PAN { get; set; }
                public static readonly string PAN_LocalName = "Permanent Account Number";
                public DateTime? PAN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TAN { get; set; }
                public static readonly string TAN_LocalName = "Tax Deduction and Collection Account Number";
            }
        }

        // Indonesia
        public class ContractData_Indonesia
        {
            public class WorkerContractData
            {
                public string? NIK { get; set; }
                public static readonly string NIK_LocalName = "Nomor Induk Kependudukan";
                public DateTime? NIK_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Nomor Paspor";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? NPWP { get; set; }
                public static readonly string NPWP_LocalName = "Nomor Pokok Wajib Pajak";
            }
        }

        // Iran
        public class ContractData_Iran
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "شماره شناسایی";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "شماره گذرنامه";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "شناسه ملی";
            }
        }

        // Iraq
        public class ContractData_Iraq
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "رقم الهوية";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "رقم جواز السفر";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "رقم التعريف الضريبي";
            }
        }

        // Ireland
        public class ContractData_Ireland
        {
            public class WorkerContractData
            {
                public string? PPSN { get; set; }
                public static readonly string PPSN_LocalName = "Personal Public Service Number";
                public DateTime? PPSN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "VAT Number";
            }
        }

        // Italy
        public class ContractData_Italy
        {
            public class WorkerContractData
            {
                public string? SSN { get; set; }
                public static readonly string SSN_LocalName = "Codice Fiscale";
                public DateTime? SSN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numero di Passaporto";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "Partita IVA";
            }
        }

        // Jamaica
        public class ContractData_Jamaica
        {
            public class WorkerContractData
            {
                public string? TRN { get; set; }
                public static readonly string TRN_LocalName = "Taxpayer Registration Number";
                public DateTime? TRN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Japan
        public class ContractData_Japan
        {
            public class WorkerContractData
            {
                public string? MyNumber { get; set; }
                public static readonly string MyNumber_LocalName = "マイナンバー";
                public DateTime? MyNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "パスポート番号";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "税務署番号";
            }
        }

        // Jordan
        public class ContractData_Jordan
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "رقم الهوية";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "رقم جواز السفر";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "رقم التعريف الضريبي";
            }
        }

        // Kazakhstan
        public class ContractData_Kazakhstan
        {
            public class WorkerContractData
            {
                public string? IIN { get; set; }
                public static readonly string IIN_LocalName = "Идентификационный номер";
                public DateTime? IIN_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Номер паспорта";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? BIN { get; set; }
                public static readonly string BIN_LocalName = "БИН";
            }
        }

        // Kenya
        public class ContractData_Kenya
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? PIN { get; set; }
                public static readonly string PIN_LocalName = "Personal Identification Number";
            }
        }

        // Kiribati
        public class ContractData_Kiribati
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Kosovo
        public class ContractData_Kosovo
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Identifikimi i qytetarit";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numri i pasaportës";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numri i identifikimit të tatimit";
            }
        }

        // Kuwait
        public class ContractData_Kuwait
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "رقم الهوية";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "رقم جواز السفر";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "رقم السجل التجاري";
            }
        }

        // Kyrgyzstan
        public class ContractData_Kyrgyzstan
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Идентификационный номер";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Номер паспорта";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Идентификационный номер налогоплательщика";
            }
        }

        // Laos
        public class ContractData_Laos
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "ບັດລະບຽບສັດສິດ";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "ບັດລະບຽບຜ່ານ";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "ເລກປະກັນສຽງ";
            }
        }

        // Latvia
        public class ContractData_Latvia
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Personas kods";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Pasu numurs";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "Pievienotās vērtības nodokļa numurs";
            }
        }

        // Lebanon
        public class ContractData_Lebanon
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "رقم الهوية";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "رقم جواز السفر";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "رقم السجل التجاري";
            }
        }

        // Lesotho
        public class ContractData_Lesotho
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Liberia
        public class ContractData_Liberia
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Libya
        public class ContractData_Libya
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "رقم الهوية";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "رقم جواز السفر";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "رقم التعريف الضريبي";
            }
        }

        // Lithuania
        public class ContractData_Lithuania
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Asmens kodas";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Pasaporte numeris";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "PVM mokėtojo kodas";
            }
        }

        // Luxembourg
        public class ContractData_Luxembourg
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Numéro d'identification";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "Numéro de TVA";
            }
        }

        // Madagascar
        public class ContractData_Madagascar
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Numéro d'identification";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'identification fiscale";
            }
        }

        // Malawi
        public class ContractData_Malawi
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Malaysia
        public class ContractData_Malaysia
        {
            public class WorkerContractData
            {
                public string? MyKad { get; set; }
                public static readonly string MyKad_LocalName = "MyKad";
                public DateTime? MyKad_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Nombor Pasport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Nombor Pendaftaran Syarikat";
            }
        }

        // Maldives
        public class ContractData_Maldives
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Mali
        public class ContractData_Mali
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Numéro d'identification";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'identification fiscale";
            }
        }

        // Malta
        public class ContractData_Malta
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "ID Card Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "VAT Number";
            }
        }

        // Mexico
        public class ContractData_Mexico
        {
            public class WorkerContractData
            {
                public string? CURP { get; set; }
                public static readonly string CURP_LocalName = "Clave Única de Registro de Población";
                public DateTime? CURP_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de Pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? RFC { get; set; }
                public static readonly string RFC_LocalName = "Registro Federal de Contribuyentes";
            }
        }

        // Micronesia
        public class ContractData_Micronesia
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Moldova
        public class ContractData_Moldova
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Codul personal";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numărul pașaportului";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numărul de identificare fiscală";
            }
        }

        // Monaco
        public class ContractData_Monaco
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Numéro d'identification";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro de TVA";
            }
        }

        // Mongolia
        public class ContractData_Mongolia
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Идэвхжүүлсэн дугаар";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Паспортын дугаар";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "НДШ-ийн дугаар";
            }
        }

        // Montenegro
        public class ContractData_Montenegro
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "JMBG";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Broj pasoša";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "PIB";
            }
        }

        // Morocco
        public class ContractData_Morocco
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "رقم الهوية";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "رقم جواز السفر";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "رقم التعريف الضريبي";
            }
        }

        // Mozambique
        public class ContractData_Mozambique
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Número de identificação";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de passaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Número de identificação fiscal";
            }
        }

        // Myanmar
        public class ContractData_Myanmar
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Namibia
        public class ContractData_Namibia
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Nauru
        public class ContractData_Nauru
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Nepal
        public class ContractData_Nepal
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Netherlands
        public class ContractData_Netherlands
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Burgerservicenummer";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Paspoortnummer";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "BTW-nummer";
            }
        }

        // New Zealand
        public class ContractData_NewZealand
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Nicaragua
        public class ContractData_Nicaragua
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Número de identificación";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Número de identificación fiscal";
            }
        }

        // Niger
        public class ContractData_Niger
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Numéro d'identification";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'identification fiscale";
            }
        }

        // Nigeria
        public class ContractData_Nigeria
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Numéro d'identification national";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'identification fiscale";
            }
        }

        // North Macedonia
        public class ContractData_NorthMacedonia
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Личен број";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Број на пасош";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Даночен идентификационен број";
            }
        }

        // Norway
        public class ContractData_Norway
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Fødselsnummer";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passnummer";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "MVA-nummer";
            }
        }

        // Oman
        public class ContractData_Oman
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "رقم الهوية";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "رقم جواز السفر";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "رقم التعريف الضريبي";
            }
        }

        // Pakistan
        public class ContractData_Pakistan
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "شخصی شناختی نمبر";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "پاسپورٹ نمبر";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "شناختی نمبر";
            }
        }

        // Palau
        public class ContractData_Palau
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Panama
        public class ContractData_Panama
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Número de identificación";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Número de identificación fiscal";
            }
        }

        // Papua New Guinea
        public class ContractData_PapuaNewGuinea
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Paraguay
        public class ContractData_Paraguay
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Número de identificación";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Número de identificación fiscal";
            }
        }

        // Peru
        public class ContractData_Peru
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Número de identificación";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Número de identificación fiscal";
            }
        }

        // Philippines
        public class ContractData_Philippines
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Poland
        public class ContractData_Poland
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Numer PESEL";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numer paszportu";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numer identyfikacji podatkowej";
            }
        }

        // Portugal
        public class ContractData_Portugal
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Número de identificação";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de passaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Número de identificação fiscal";
            }
        }

        // Qatar
        public class ContractData_Qatar
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "رقم الهوية";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "رقم جواز السفر";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "رقم التعريف الضريبي";
            }
        }

        // Romania
        public class ContractData_Romania
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Număr de identificare";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Număr de pașaport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Codul de identificare fiscală";
            }
        }

        // Rwanda
        public class ContractData_Rwanda
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Saudi Arabia
        public class ContractData_SaudiArabia
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "رقم الهوية";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "رقم جواز السفر";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "رقم التعريف الضريبي";
            }
        }

        // Senegal
        public class ContractData_Senegal
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Numéro d'identification national";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'identification fiscale";
            }
        }

        // Serbia
        public class ContractData_Serbia
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "JMBG";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Broj pasoša";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "PIB";
            }
        }

        // Seychelles
        public class ContractData_Seychelles
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set;  }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Singapore
        public class ContractData_Singapore
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National Registration Identity Card Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // Slovakia
        public class ContractData_Slovakia
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Rodné číslo";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Číslo pasu";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Identifikačné číslo organizácie";
            }
        }

        // Slovenia
        public class ContractData_Slovenia
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Osebna številka";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Številka potnega lista";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Davčna številka";
            }
        }

        // Solomon Islands
        public class ContractData_SolomonIslands
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // South Africa
        public class ContractData_SouthAfrica
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Numéro d'identification nationale";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'identification fiscale";
            }
        }

        // South Korea
        public class ContractData_SouthKorea
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "주민등록번호";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "여권번호";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "세금 식별 번호";
            }
        }

        // Spain
        public class ContractData_Spain
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Número de identificación";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Número de identificación fiscal";
            }
        }

        // Sweden
        public class ContractData_Sweden
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Personnummer";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passnummer";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "Momsregistreringsnummer";
            }
        }

        // Switzerland
        public class ContractData_Switzerland
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "AHV-Nummer";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passnummer";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? VATNumber { get; set; }
                public static readonly string VATNumber_LocalName = "MwSt-Nummer";
            }
        }

        // Taiwan
        public class ContractData_Taiwan
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "身分證號";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "護照號碼";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "統一編號";
            }
        }

        // Thailand
        public class ContractData_Thailand
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "เลขประจำตัวประชาชน";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "หมายเลขหนังสือเดินทาง";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "หมายเลขประจำตัวผู้เสียภาษี";
            }
        }

        // Togo
        public class ContractData_Togo
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Numéro d'identification nationale";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Numéro de passeport";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Numéro d'identification fiscale";
            }
        }

        // Trinidad and Tobago
        public class ContractData_TrinidadAndTobago
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National ID Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // United Arab Emirates
        public class ContractData_UnitedArabEmirates
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "رقم الهوية";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "رقم جواز السفر";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "رقم التعريف الضريبي";
            }
        }

        // United Kingdom
        public class ContractData_UnitedKingdom
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "National Insurance Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Tax Identification Number";
            }
        }

        // United States
        public class ContractData_UnitedStates
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Social Security Number";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Passport Number";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Employer Identification Number";
            }
        }

        // Uruguay
        public class ContractData_Uruguay
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Número de identificación";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Número de identificación fiscal";
            }
        }

        // Venezuela
        public class ContractData_Venezuela
        {
            public class WorkerContractData
            {
                public string? IDNumber { get; set; }
                public static readonly string IDNumber_LocalName = "Cédula de identidad";
                public DateTime? IDNumber_ExpirationDate { get; set; }

                public string? PassportNumber { get; set; }
                public static readonly string PassportNumber_LocalName = "Número de pasaporte";
                public DateTime? PassportNumber_ExpirationDate { get; set; }

                public string? BankAccountNumber { get; set; }
            }

            public class CompanyContractData
            {
                public string? FullAddress { get; set; }
                public string? TaxID { get; set; }
                public static readonly string TaxID_LocalName = "Número de identificación fiscal";
            }
        }


    }
}