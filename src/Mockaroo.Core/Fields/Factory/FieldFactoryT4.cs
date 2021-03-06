﻿namespace Gigobyte.Mockaroo.Fields.Factory
{
	/// <summary>
	/// Provides a method to create an <see cref="IField"/> from a DataType value.
	/// </summary>
	public partial class FieldFactory : IFieldFactory<DataType>
	{
		/// <summary>
		/// Creates a <see cref="IField"/> instance from a DataType value.
		/// </summary>
		public IField CreateInstance(DataType dataType)
		{
			switch(dataType)
			{
				default:
					throw new System.ArgumentException($"'{dataType}' is not a unknown data type.");

				case DataType.AppBundleID: 
					return new AppBundleIDField();
				case DataType.AppName: 
					return new AppNameField();
				case DataType.AppVersion: 
					return new AppVersionField();
				case DataType.Avatar: 
					return new AvatarField();
				case DataType.Base64ImageURL: 
					return new Base64ImageURLField();
				case DataType.BitcoinAddress: 
					return new BitcoinAddressField();
				case DataType.Blank: 
					return new BlankField();
				case DataType.Boolean: 
					return new BooleanField();
				case DataType.City: 
					return new CityField();
				case DataType.Color: 
					return new ColorField();
				case DataType.CompanyName: 
					return new CompanyNameField();
				case DataType.Country: 
					return new CountryField();
				case DataType.CountryCode: 
					return new CountryCodeField();
				case DataType.CreditCardNumber: 
					return new CreditCardNumberField();
				case DataType.CreditCardType: 
					return new CreditCardTypeField();
				case DataType.Currency: 
					return new CurrencyField();
				case DataType.CurrencyCode: 
					return new CurrencyCodeField();
				case DataType.CustomList: 
					return new CustomListField();
				case DataType.DatasetColumn: 
					return new DatasetColumnField();
				case DataType.Date: 
					return new DateField();
				case DataType.DomainName: 
					return new DomainNameField();
				case DataType.DrugCompany: 
					return new DrugCompanyField();
				case DataType.DrugNameBrand: 
					return new DrugNameBrandField();
				case DataType.DrugNameGeneric: 
					return new DrugNameGenericField();
				case DataType.DummyImageURL: 
					return new DummyImageURLField();
				case DataType.EmailAddress: 
					return new EmailAddressField();
				case DataType.Encrypt: 
					return new EncryptField();
				case DataType.FamilyNameChinese: 
					return new FamilyNameChineseField();
				case DataType.FDANDCCode: 
					return new FDANDCCodeField();
				case DataType.FileName: 
					return new FileNameField();
				case DataType.FirstName: 
					return new FirstNameField();
				case DataType.FirstNameEuropean: 
					return new FirstNameEuropeanField();
				case DataType.FirstNameFemale: 
					return new FirstNameFemaleField();
				case DataType.FirstNameMale: 
					return new FirstNameMaleField();
				case DataType.Formula: 
					return new FormulaField();
				case DataType.Frequency: 
					return new FrequencyField();
				case DataType.FullName: 
					return new FullNameField();
				case DataType.Gender: 
					return new GenderField();
				case DataType.GenderAbbreviated: 
					return new GenderAbbreviatedField();
				case DataType.GivenNameChinese: 
					return new GivenNameChineseField();
				case DataType.GUID: 
					return new GUIDField();
				case DataType.HexColor: 
					return new HexColorField();
				case DataType.IBAN: 
					return new IBANField();
				case DataType.ICD9DiagnosisCode: 
					return new ICD9DiagnosisCodeField();
				case DataType.ICD9DxDescLong: 
					return new ICD9DxDescLongField();
				case DataType.ICD9DxDescShort: 
					return new ICD9DxDescShortField();
				case DataType.ICD9ProcDescLong: 
					return new ICD9ProcDescLongField();
				case DataType.ICD9ProcDescShort: 
					return new ICD9ProcDescShortField();
				case DataType.ICD9ProcedureCode: 
					return new ICD9ProcedureCodeField();
				case DataType.IPAddressV4: 
					return new IPAddressV4Field();
				case DataType.IPAddressV4CIDR: 
					return new IPAddressV4CIDRField();
				case DataType.IPAddressV6: 
					return new IPAddressV6Field();
				case DataType.IPAddressV6CIDR: 
					return new IPAddressV6CIDRField();
				case DataType.ISBN: 
					return new ISBNField();
				case DataType.JobTitle: 
					return new JobTitleField();
				case DataType.JSONArray: 
					return new JSONArrayField();
				case DataType.Language: 
					return new LanguageField();
				case DataType.LastName: 
					return new LastNameField();
				case DataType.Latitude: 
					return new LatitudeField();
				case DataType.LinkedInSkill: 
					return new LinkedInSkillField();
				case DataType.Longitude: 
					return new LongitudeField();
				case DataType.MACAddress: 
					return new MACAddressField();
				case DataType.MD5: 
					return new MD5Field();
				case DataType.MIMEType: 
					return new MIMETypeField();
				case DataType.Money: 
					return new MoneyField();
				case DataType.MongoDBObjectID: 
					return new MongoDBObjectIDField();
				case DataType.NaughtyString: 
					return new NaughtyStringField();
				case DataType.NormalDistribution: 
					return new NormalDistributionField();
				case DataType.Number: 
					return new NumberField();
				case DataType.Paragraphs: 
					return new ParagraphsField();
				case DataType.Password: 
					return new PasswordField();
				case DataType.Phone: 
					return new PhoneField();
				case DataType.PoissonDistribution: 
					return new PoissonDistributionField();
				case DataType.PostalCode: 
					return new PostalCodeField();
				case DataType.Race: 
					return new RaceField();
				case DataType.RegularExpression: 
					return new RegularExpressionField();
				case DataType.RowNumber: 
					return new RowNumberField();
				case DataType.Scenario: 
					return new ScenarioField();
				case DataType.Sentences: 
					return new SentencesField();
				case DataType.Sequence: 
					return new SequenceField();
				case DataType.SHA1: 
					return new SHA1Field();
				case DataType.SHA256: 
					return new SHA256Field();
				case DataType.ShirtSize: 
					return new ShirtSizeField();
				case DataType.ShortHexColor: 
					return new ShortHexColorField();
				case DataType.SQLExpression: 
					return new SQLExpressionField();
				case DataType.SSN: 
					return new SSNField();
				case DataType.State: 
					return new StateField();
				case DataType.StateAbbreviated: 
					return new StateAbbreviatedField();
				case DataType.StreetAddress: 
					return new StreetAddressField();
				case DataType.StreetName: 
					return new StreetNameField();
				case DataType.StreetNumber: 
					return new StreetNumberField();
				case DataType.StreetSuffix: 
					return new StreetSuffixField();
				case DataType.Suffix: 
					return new SuffixField();
				case DataType.Template: 
					return new TemplateField();
				case DataType.Time: 
					return new TimeField();
				case DataType.TimeZone: 
					return new TimeZoneField();
				case DataType.Title: 
					return new TitleField();
				case DataType.TopLevelDomain: 
					return new TopLevelDomainField();
				case DataType.URL: 
					return new URLField();
				case DataType.UserAgent: 
					return new UserAgentField();
				case DataType.UserName: 
					return new UserNameField();
				case DataType.Words: 
					return new WordsField();
			}
		}
	}
}