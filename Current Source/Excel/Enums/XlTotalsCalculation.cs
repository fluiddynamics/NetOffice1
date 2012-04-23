using System;
using NetOffice;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Excel", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlTotalsCalculation
	{
		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlTotalsCalculationNone = 0,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlTotalsCalculationSum = 1,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlTotalsCalculationAverage = 2,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlTotalsCalculationCount = 3,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlTotalsCalculationCountNums = 4,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlTotalsCalculationMin = 5,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>6</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlTotalsCalculationMax = 6,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>7</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlTotalsCalculationStdDev = 7,

		 /// <summary>
		 /// SupportByVersion Excel 11, 12, 14
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByVersionAttribute("Excel", 11,12,14)]
		 xlTotalsCalculationVar = 8,

		 /// <summary>
		 /// SupportByVersion Excel 12, 14
		 /// </summary>
		 /// <remarks>9</remarks>
		 [SupportByVersionAttribute("Excel", 12,14)]
		 xlTotalsCalculationCustom = 9
	}
}