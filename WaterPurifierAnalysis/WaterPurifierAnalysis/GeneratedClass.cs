﻿using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using X14 = DocumentFormat.OpenXml.Office2010.Excel;
using A = DocumentFormat.OpenXml.Drawing;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;
using Vt = DocumentFormat.OpenXml.VariantTypes;
using Op = DocumentFormat.OpenXml.CustomProperties;

namespace WaterPurifierAnalysis
{
    public class GeneratedClass
    {
        // Creates a SpreadsheetDocument.
        public void CreatePackage(string filePath)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                CreateParts(package);
            }
        }

        // Adds child parts and generates content of the specified part.
        private void CreateParts(SpreadsheetDocument document)
        {
            WorkbookPart workbookPart1 = document.AddWorkbookPart();
            GenerateWorkbookPart1Content(workbookPart1);

            SharedStringTablePart sharedStringTablePart1 = workbookPart1.AddNewPart<SharedStringTablePart>("rId4");
            GenerateSharedStringTablePart1Content(sharedStringTablePart1);

            WorkbookStylesPart workbookStylesPart1 = workbookPart1.AddNewPart<WorkbookStylesPart>("rId3");
            GenerateWorkbookStylesPart1Content(workbookStylesPart1);

            ThemePart themePart1 = workbookPart1.AddNewPart<ThemePart>("rId2");
            GenerateThemePart1Content(themePart1);

            WorksheetPart worksheetPart1 = workbookPart1.AddNewPart<WorksheetPart>("rId1");
            GenerateWorksheetPart1Content(worksheetPart1);

            ExtendedFilePropertiesPart extendedFilePropertiesPart1 = document.AddNewPart<ExtendedFilePropertiesPart>("rId2");
            GenerateExtendedFilePropertiesPart1Content(extendedFilePropertiesPart1);

            CustomFilePropertiesPart customFilePropertiesPart1 = document.AddNewPart<CustomFilePropertiesPart>("rId4");
            GenerateCustomFilePropertiesPart1Content(customFilePropertiesPart1);

            SetPackageProperties(document);
        }

        // Generates content of workbookPart1.
        private void GenerateWorkbookPart1Content(WorkbookPart workbookPart1)
        {
            Workbook workbook1 = new Workbook();
            workbook1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            FileVersion fileVersion1 = new FileVersion() { ApplicationName = "xl", LastEdited = "3", LowestEdited = "5", BuildVersion = "9302" };
            WorkbookProperties workbookProperties1 = new WorkbookProperties();

            BookViews bookViews1 = new BookViews();
            WorkbookView workbookView1 = new WorkbookView() { WindowWidth = (UInt32Value)20475U, WindowHeight = (UInt32Value)8025U };

            bookViews1.Append(workbookView1);

            Sheets sheets1 = new Sheets();
            Sheet sheet1 = new Sheet() { Name = "Sheet1", SheetId = (UInt32Value)1U, Id = "rId1" };

            sheets1.Append(sheet1);
            CalculationProperties calculationProperties1 = new CalculationProperties() { CalculationId = (UInt32Value)144525U };

            workbook1.Append(fileVersion1);
            workbook1.Append(workbookProperties1);
            workbook1.Append(bookViews1);
            workbook1.Append(sheets1);
            workbook1.Append(calculationProperties1);

            workbookPart1.Workbook = workbook1;
        }

        // Generates content of sharedStringTablePart1.
        private void GenerateSharedStringTablePart1Content(SharedStringTablePart sharedStringTablePart1)
        {
            SharedStringTable sharedStringTable1 = new SharedStringTable() { Count = (UInt32Value)3U, UniqueCount = (UInt32Value)3U };

            SharedStringItem sharedStringItem1 = new SharedStringItem();
            Text text1 = new Text();
            text1.Text = "Date";

            sharedStringItem1.Append(text1);

            SharedStringItem sharedStringItem2 = new SharedStringItem();
            Text text2 = new Text();
            text2.Text = "Time";

            sharedStringItem2.Append(text2);

            SharedStringItem sharedStringItem3 = new SharedStringItem();
            Text text3 = new Text();
            text3.Text = "Inlet Temperature";

            sharedStringItem3.Append(text3);

            sharedStringTable1.Append(sharedStringItem1);
            sharedStringTable1.Append(sharedStringItem2);
            sharedStringTable1.Append(sharedStringItem3);

            sharedStringTablePart1.SharedStringTable = sharedStringTable1;
        }

        // Generates content of workbookStylesPart1.
        private void GenerateWorkbookStylesPart1Content(WorkbookStylesPart workbookStylesPart1)
        {
            Stylesheet stylesheet1 = new Stylesheet();

            NumberingFormats numberingFormats1 = new NumberingFormats() { Count = (UInt32Value)6U };
            NumberingFormat numberingFormat1 = new NumberingFormat() { NumberFormatId = (UInt32Value)44U, FormatCode = "_(\"$\"* #,##0.00_);_(\"$\"* \\(#,##0.00\\);_(\"$\"* \"-\"??_);_(@_)" };
            NumberingFormat numberingFormat2 = new NumberingFormat() { NumberFormatId = (UInt32Value)176U, FormatCode = "h:mm;@" };
            NumberingFormat numberingFormat3 = new NumberingFormat() { NumberFormatId = (UInt32Value)177U, FormatCode = "mm/dd/yy;@" };
            NumberingFormat numberingFormat4 = new NumberingFormat() { NumberFormatId = (UInt32Value)178U, FormatCode = "_ * #,##0.00_ ;_ * \\-#,##0.00_ ;_ * \"-\"??_ ;_ @_ " };
            NumberingFormat numberingFormat5 = new NumberingFormat() { NumberFormatId = (UInt32Value)42U, FormatCode = "_(\"$\"* #,##0_);_(\"$\"* \\(#,##0\\);_(\"$\"* \"-\"_);_(@_)" };
            NumberingFormat numberingFormat6 = new NumberingFormat() { NumberFormatId = (UInt32Value)179U, FormatCode = "_ * #,##0_ ;_ * \\-#,##0_ ;_ * \"-\"_ ;_ @_ " };

            numberingFormats1.Append(numberingFormat1);
            numberingFormats1.Append(numberingFormat2);
            numberingFormats1.Append(numberingFormat3);
            numberingFormats1.Append(numberingFormat4);
            numberingFormats1.Append(numberingFormat5);
            numberingFormats1.Append(numberingFormat6);

            Fonts fonts1 = new Fonts() { Count = (UInt32Value)20U };

            Font font1 = new Font();
            FontSize fontSize1 = new FontSize() { Val = 11D };
            Color color1 = new Color() { Theme = (UInt32Value)1U };
            FontName fontName1 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet1 = new FontCharSet() { Val = 134 };
            FontScheme fontScheme1 = new FontScheme() { Val = FontSchemeValues.Minor };

            font1.Append(fontSize1);
            font1.Append(color1);
            font1.Append(fontName1);
            font1.Append(fontCharSet1);
            font1.Append(fontScheme1);

            Font font2 = new Font();
            FontSize fontSize2 = new FontSize() { Val = 11D };
            Color color2 = new Color() { Rgb = "FF006100" };
            FontName fontName2 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet2 = new FontCharSet() { Val = 0 };
            FontScheme fontScheme2 = new FontScheme() { Val = FontSchemeValues.Minor };

            font2.Append(fontSize2);
            font2.Append(color2);
            font2.Append(fontName2);
            font2.Append(fontCharSet2);
            font2.Append(fontScheme2);

            Font font3 = new Font();
            FontSize fontSize3 = new FontSize() { Val = 11D };
            Color color3 = new Color() { Theme = (UInt32Value)1U };
            FontName fontName3 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet3 = new FontCharSet() { Val = 0 };
            FontScheme fontScheme3 = new FontScheme() { Val = FontSchemeValues.Minor };

            font3.Append(fontSize3);
            font3.Append(color3);
            font3.Append(fontName3);
            font3.Append(fontCharSet3);
            font3.Append(fontScheme3);

            Font font4 = new Font();
            Bold bold1 = new Bold();
            FontSize fontSize4 = new FontSize() { Val = 11D };
            Color color4 = new Color() { Rgb = "FFFFFFFF" };
            FontName fontName4 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet4 = new FontCharSet() { Val = 0 };
            FontScheme fontScheme4 = new FontScheme() { Val = FontSchemeValues.Minor };

            font4.Append(bold1);
            font4.Append(fontSize4);
            font4.Append(color4);
            font4.Append(fontName4);
            font4.Append(fontCharSet4);
            font4.Append(fontScheme4);

            Font font5 = new Font();
            Bold bold2 = new Bold();
            FontSize fontSize5 = new FontSize() { Val = 13D };
            Color color5 = new Color() { Theme = (UInt32Value)3U };
            FontName fontName5 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet5 = new FontCharSet() { Val = 134 };
            FontScheme fontScheme5 = new FontScheme() { Val = FontSchemeValues.Minor };

            font5.Append(bold2);
            font5.Append(fontSize5);
            font5.Append(color5);
            font5.Append(fontName5);
            font5.Append(fontCharSet5);
            font5.Append(fontScheme5);

            Font font6 = new Font();
            Underline underline1 = new Underline();
            FontSize fontSize6 = new FontSize() { Val = 11D };
            Color color6 = new Color() { Rgb = "FF0000FF" };
            FontName fontName6 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet6 = new FontCharSet() { Val = 0 };
            FontScheme fontScheme6 = new FontScheme() { Val = FontSchemeValues.Minor };

            font6.Append(underline1);
            font6.Append(fontSize6);
            font6.Append(color6);
            font6.Append(fontName6);
            font6.Append(fontCharSet6);
            font6.Append(fontScheme6);

            Font font7 = new Font();
            FontSize fontSize7 = new FontSize() { Val = 11D };
            Color color7 = new Color() { Theme = (UInt32Value)0U };
            FontName fontName7 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet7 = new FontCharSet() { Val = 0 };
            FontScheme fontScheme7 = new FontScheme() { Val = FontSchemeValues.Minor };

            font7.Append(fontSize7);
            font7.Append(color7);
            font7.Append(fontName7);
            font7.Append(fontCharSet7);
            font7.Append(fontScheme7);

            Font font8 = new Font();
            Italic italic1 = new Italic();
            FontSize fontSize8 = new FontSize() { Val = 11D };
            Color color8 = new Color() { Rgb = "FF7F7F7F" };
            FontName fontName8 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet8 = new FontCharSet() { Val = 0 };
            FontScheme fontScheme8 = new FontScheme() { Val = FontSchemeValues.Minor };

            font8.Append(italic1);
            font8.Append(fontSize8);
            font8.Append(color8);
            font8.Append(fontName8);
            font8.Append(fontCharSet8);
            font8.Append(fontScheme8);

            Font font9 = new Font();
            Underline underline2 = new Underline();
            FontSize fontSize9 = new FontSize() { Val = 11D };
            Color color9 = new Color() { Rgb = "FF800080" };
            FontName fontName9 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet9 = new FontCharSet() { Val = 0 };
            FontScheme fontScheme9 = new FontScheme() { Val = FontSchemeValues.Minor };

            font9.Append(underline2);
            font9.Append(fontSize9);
            font9.Append(color9);
            font9.Append(fontName9);
            font9.Append(fontCharSet9);
            font9.Append(fontScheme9);

            Font font10 = new Font();
            Bold bold3 = new Bold();
            FontSize fontSize10 = new FontSize() { Val = 11D };
            Color color10 = new Color() { Theme = (UInt32Value)1U };
            FontName fontName10 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet10 = new FontCharSet() { Val = 0 };
            FontScheme fontScheme10 = new FontScheme() { Val = FontSchemeValues.Minor };

            font10.Append(bold3);
            font10.Append(fontSize10);
            font10.Append(color10);
            font10.Append(fontName10);
            font10.Append(fontCharSet10);
            font10.Append(fontScheme10);

            Font font11 = new Font();
            Bold bold4 = new Bold();
            FontSize fontSize11 = new FontSize() { Val = 18D };
            Color color11 = new Color() { Theme = (UInt32Value)3U };
            FontName fontName11 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet11 = new FontCharSet() { Val = 134 };
            FontScheme fontScheme11 = new FontScheme() { Val = FontSchemeValues.Minor };

            font11.Append(bold4);
            font11.Append(fontSize11);
            font11.Append(color11);
            font11.Append(fontName11);
            font11.Append(fontCharSet11);
            font11.Append(fontScheme11);

            Font font12 = new Font();
            FontSize fontSize12 = new FontSize() { Val = 11D };
            Color color12 = new Color() { Rgb = "FFFF0000" };
            FontName fontName12 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet12 = new FontCharSet() { Val = 0 };
            FontScheme fontScheme12 = new FontScheme() { Val = FontSchemeValues.Minor };

            font12.Append(fontSize12);
            font12.Append(color12);
            font12.Append(fontName12);
            font12.Append(fontCharSet12);
            font12.Append(fontScheme12);

            Font font13 = new Font();
            FontSize fontSize13 = new FontSize() { Val = 11D };
            Color color13 = new Color() { Rgb = "FFFA7D00" };
            FontName fontName13 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet13 = new FontCharSet() { Val = 0 };
            FontScheme fontScheme13 = new FontScheme() { Val = FontSchemeValues.Minor };

            font13.Append(fontSize13);
            font13.Append(color13);
            font13.Append(fontName13);
            font13.Append(fontCharSet13);
            font13.Append(fontScheme13);

            Font font14 = new Font();
            Bold bold5 = new Bold();
            FontSize fontSize14 = new FontSize() { Val = 11D };
            Color color14 = new Color() { Theme = (UInt32Value)3U };
            FontName fontName14 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet14 = new FontCharSet() { Val = 134 };
            FontScheme fontScheme14 = new FontScheme() { Val = FontSchemeValues.Minor };

            font14.Append(bold5);
            font14.Append(fontSize14);
            font14.Append(color14);
            font14.Append(fontName14);
            font14.Append(fontCharSet14);
            font14.Append(fontScheme14);

            Font font15 = new Font();
            Bold bold6 = new Bold();
            FontSize fontSize15 = new FontSize() { Val = 15D };
            Color color15 = new Color() { Theme = (UInt32Value)3U };
            FontName fontName15 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet15 = new FontCharSet() { Val = 134 };
            FontScheme fontScheme15 = new FontScheme() { Val = FontSchemeValues.Minor };

            font15.Append(bold6);
            font15.Append(fontSize15);
            font15.Append(color15);
            font15.Append(fontName15);
            font15.Append(fontCharSet15);
            font15.Append(fontScheme15);

            Font font16 = new Font();
            FontSize fontSize16 = new FontSize() { Val = 11D };
            Color color16 = new Color() { Rgb = "FF3F3F76" };
            FontName fontName16 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet16 = new FontCharSet() { Val = 0 };
            FontScheme fontScheme16 = new FontScheme() { Val = FontSchemeValues.Minor };

            font16.Append(fontSize16);
            font16.Append(color16);
            font16.Append(fontName16);
            font16.Append(fontCharSet16);
            font16.Append(fontScheme16);

            Font font17 = new Font();
            Bold bold7 = new Bold();
            FontSize fontSize17 = new FontSize() { Val = 11D };
            Color color17 = new Color() { Rgb = "FF3F3F3F" };
            FontName fontName17 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet17 = new FontCharSet() { Val = 0 };
            FontScheme fontScheme17 = new FontScheme() { Val = FontSchemeValues.Minor };

            font17.Append(bold7);
            font17.Append(fontSize17);
            font17.Append(color17);
            font17.Append(fontName17);
            font17.Append(fontCharSet17);
            font17.Append(fontScheme17);

            Font font18 = new Font();
            Bold bold8 = new Bold();
            FontSize fontSize18 = new FontSize() { Val = 11D };
            Color color18 = new Color() { Rgb = "FFFA7D00" };
            FontName fontName18 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet18 = new FontCharSet() { Val = 0 };
            FontScheme fontScheme18 = new FontScheme() { Val = FontSchemeValues.Minor };

            font18.Append(bold8);
            font18.Append(fontSize18);
            font18.Append(color18);
            font18.Append(fontName18);
            font18.Append(fontCharSet18);
            font18.Append(fontScheme18);

            Font font19 = new Font();
            FontSize fontSize19 = new FontSize() { Val = 11D };
            Color color19 = new Color() { Rgb = "FF9C6500" };
            FontName fontName19 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet19 = new FontCharSet() { Val = 0 };
            FontScheme fontScheme19 = new FontScheme() { Val = FontSchemeValues.Minor };

            font19.Append(fontSize19);
            font19.Append(color19);
            font19.Append(fontName19);
            font19.Append(fontCharSet19);
            font19.Append(fontScheme19);

            Font font20 = new Font();
            FontSize fontSize20 = new FontSize() { Val = 11D };
            Color color20 = new Color() { Rgb = "FF9C0006" };
            FontName fontName20 = new FontName() { Val = "Calibri" };
            FontCharSet fontCharSet20 = new FontCharSet() { Val = 0 };
            FontScheme fontScheme20 = new FontScheme() { Val = FontSchemeValues.Minor };

            font20.Append(fontSize20);
            font20.Append(color20);
            font20.Append(fontName20);
            font20.Append(fontCharSet20);
            font20.Append(fontScheme20);

            fonts1.Append(font1);
            fonts1.Append(font2);
            fonts1.Append(font3);
            fonts1.Append(font4);
            fonts1.Append(font5);
            fonts1.Append(font6);
            fonts1.Append(font7);
            fonts1.Append(font8);
            fonts1.Append(font9);
            fonts1.Append(font10);
            fonts1.Append(font11);
            fonts1.Append(font12);
            fonts1.Append(font13);
            fonts1.Append(font14);
            fonts1.Append(font15);
            fonts1.Append(font16);
            fonts1.Append(font17);
            fonts1.Append(font18);
            fonts1.Append(font19);
            fonts1.Append(font20);

            Fills fills1 = new Fills() { Count = (UInt32Value)34U };

            Fill fill1 = new Fill();
            PatternFill patternFill1 = new PatternFill() { PatternType = PatternValues.None };

            fill1.Append(patternFill1);

            Fill fill2 = new Fill();
            PatternFill patternFill2 = new PatternFill() { PatternType = PatternValues.Gray125 };

            fill2.Append(patternFill2);

            Fill fill3 = new Fill();

            PatternFill patternFill3 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor1 = new ForegroundColor() { Theme = (UInt32Value)4U, Tint = 0.8D };
            BackgroundColor backgroundColor1 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill3.Append(foregroundColor1);
            patternFill3.Append(backgroundColor1);

            fill3.Append(patternFill3);

            Fill fill4 = new Fill();

            PatternFill patternFill4 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor2 = new ForegroundColor() { Rgb = "FFFFFFCC" };
            BackgroundColor backgroundColor2 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill4.Append(foregroundColor2);
            patternFill4.Append(backgroundColor2);

            fill4.Append(patternFill4);

            Fill fill5 = new Fill();

            PatternFill patternFill5 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor3 = new ForegroundColor() { Rgb = "FFC6EFCE" };
            BackgroundColor backgroundColor3 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill5.Append(foregroundColor3);
            patternFill5.Append(backgroundColor3);

            fill5.Append(patternFill5);

            Fill fill6 = new Fill();

            PatternFill patternFill6 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor4 = new ForegroundColor() { Theme = (UInt32Value)4U, Tint = 0.599993896298105D };
            BackgroundColor backgroundColor4 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill6.Append(foregroundColor4);
            patternFill6.Append(backgroundColor4);

            fill6.Append(patternFill6);

            Fill fill7 = new Fill();

            PatternFill patternFill7 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor5 = new ForegroundColor() { Rgb = "FFA5A5A5" };
            BackgroundColor backgroundColor5 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill7.Append(foregroundColor5);
            patternFill7.Append(backgroundColor5);

            fill7.Append(patternFill7);

            Fill fill8 = new Fill();

            PatternFill patternFill8 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor6 = new ForegroundColor() { Theme = (UInt32Value)8U, Tint = 0.799981688894314D };
            BackgroundColor backgroundColor6 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill8.Append(foregroundColor6);
            patternFill8.Append(backgroundColor6);

            fill8.Append(patternFill8);

            Fill fill9 = new Fill();

            PatternFill patternFill9 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor7 = new ForegroundColor() { Theme = (UInt32Value)7U, Tint = 0.399975585192419D };
            BackgroundColor backgroundColor7 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill9.Append(foregroundColor7);
            patternFill9.Append(backgroundColor7);

            fill9.Append(patternFill9);

            Fill fill10 = new Fill();

            PatternFill patternFill10 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor8 = new ForegroundColor() { Theme = (UInt32Value)4U, Tint = 0.799981688894314D };
            BackgroundColor backgroundColor8 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill10.Append(foregroundColor8);
            patternFill10.Append(backgroundColor8);

            fill10.Append(patternFill10);

            Fill fill11 = new Fill();

            PatternFill patternFill11 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor9 = new ForegroundColor() { Theme = (UInt32Value)6U, Tint = 0.599993896298105D };
            BackgroundColor backgroundColor9 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill11.Append(foregroundColor9);
            patternFill11.Append(backgroundColor9);

            fill11.Append(patternFill11);

            Fill fill12 = new Fill();

            PatternFill patternFill12 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor10 = new ForegroundColor() { Theme = (UInt32Value)5U, Tint = 0.599993896298105D };
            BackgroundColor backgroundColor10 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill12.Append(foregroundColor10);
            patternFill12.Append(backgroundColor10);

            fill12.Append(patternFill12);

            Fill fill13 = new Fill();

            PatternFill patternFill13 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor11 = new ForegroundColor() { Theme = (UInt32Value)5U, Tint = 0.399975585192419D };
            BackgroundColor backgroundColor11 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill13.Append(foregroundColor11);
            patternFill13.Append(backgroundColor11);

            fill13.Append(patternFill13);

            Fill fill14 = new Fill();

            PatternFill patternFill14 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor12 = new ForegroundColor() { Theme = (UInt32Value)6U, Tint = 0.799981688894314D };
            BackgroundColor backgroundColor12 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill14.Append(foregroundColor12);
            patternFill14.Append(backgroundColor12);

            fill14.Append(patternFill14);

            Fill fill15 = new Fill();

            PatternFill patternFill15 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor13 = new ForegroundColor() { Theme = (UInt32Value)4U, Tint = 0.399975585192419D };
            BackgroundColor backgroundColor13 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill15.Append(foregroundColor13);
            patternFill15.Append(backgroundColor13);

            fill15.Append(patternFill15);

            Fill fill16 = new Fill();

            PatternFill patternFill16 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor14 = new ForegroundColor() { Rgb = "FFFFCC99" };
            BackgroundColor backgroundColor14 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill16.Append(foregroundColor14);
            patternFill16.Append(backgroundColor14);

            fill16.Append(patternFill16);

            Fill fill17 = new Fill();

            PatternFill patternFill17 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor15 = new ForegroundColor() { Theme = (UInt32Value)8U, Tint = 0.599993896298105D };
            BackgroundColor backgroundColor15 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill17.Append(foregroundColor15);
            patternFill17.Append(backgroundColor15);

            fill17.Append(patternFill17);

            Fill fill18 = new Fill();

            PatternFill patternFill18 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor16 = new ForegroundColor() { Theme = (UInt32Value)6U, Tint = 0.399975585192419D };
            BackgroundColor backgroundColor16 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill18.Append(foregroundColor16);
            patternFill18.Append(backgroundColor16);

            fill18.Append(patternFill18);

            Fill fill19 = new Fill();

            PatternFill patternFill19 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor17 = new ForegroundColor() { Rgb = "FFF2F2F2" };
            BackgroundColor backgroundColor17 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill19.Append(foregroundColor17);
            patternFill19.Append(backgroundColor17);

            fill19.Append(patternFill19);

            Fill fill20 = new Fill();

            PatternFill patternFill20 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor18 = new ForegroundColor() { Rgb = "FFFFEB9C" };
            BackgroundColor backgroundColor18 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill20.Append(foregroundColor18);
            patternFill20.Append(backgroundColor18);

            fill20.Append(patternFill20);

            Fill fill21 = new Fill();

            PatternFill patternFill21 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor19 = new ForegroundColor() { Rgb = "FFFFC7CE" };
            BackgroundColor backgroundColor19 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill21.Append(foregroundColor19);
            patternFill21.Append(backgroundColor19);

            fill21.Append(patternFill21);

            Fill fill22 = new Fill();

            PatternFill patternFill22 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor20 = new ForegroundColor() { Theme = (UInt32Value)4U };
            BackgroundColor backgroundColor20 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill22.Append(foregroundColor20);
            patternFill22.Append(backgroundColor20);

            fill22.Append(patternFill22);

            Fill fill23 = new Fill();

            PatternFill patternFill23 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor21 = new ForegroundColor() { Theme = (UInt32Value)6U };
            BackgroundColor backgroundColor21 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill23.Append(foregroundColor21);
            patternFill23.Append(backgroundColor21);

            fill23.Append(patternFill23);

            Fill fill24 = new Fill();

            PatternFill patternFill24 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor22 = new ForegroundColor() { Theme = (UInt32Value)5U, Tint = 0.799981688894314D };
            BackgroundColor backgroundColor22 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill24.Append(foregroundColor22);
            patternFill24.Append(backgroundColor22);

            fill24.Append(patternFill24);

            Fill fill25 = new Fill();

            PatternFill patternFill25 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor23 = new ForegroundColor() { Theme = (UInt32Value)5U };
            BackgroundColor backgroundColor23 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill25.Append(foregroundColor23);
            patternFill25.Append(backgroundColor23);

            fill25.Append(patternFill25);

            Fill fill26 = new Fill();

            PatternFill patternFill26 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor24 = new ForegroundColor() { Theme = (UInt32Value)8U, Tint = 0.399975585192419D };
            BackgroundColor backgroundColor24 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill26.Append(foregroundColor24);
            patternFill26.Append(backgroundColor24);

            fill26.Append(patternFill26);

            Fill fill27 = new Fill();

            PatternFill patternFill27 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor25 = new ForegroundColor() { Theme = (UInt32Value)9U, Tint = 0.799981688894314D };
            BackgroundColor backgroundColor25 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill27.Append(foregroundColor25);
            patternFill27.Append(backgroundColor25);

            fill27.Append(patternFill27);

            Fill fill28 = new Fill();

            PatternFill patternFill28 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor26 = new ForegroundColor() { Theme = (UInt32Value)9U, Tint = 0.599993896298105D };
            BackgroundColor backgroundColor26 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill28.Append(foregroundColor26);
            patternFill28.Append(backgroundColor26);

            fill28.Append(patternFill28);

            Fill fill29 = new Fill();

            PatternFill patternFill29 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor27 = new ForegroundColor() { Theme = (UInt32Value)7U };
            BackgroundColor backgroundColor27 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill29.Append(foregroundColor27);
            patternFill29.Append(backgroundColor27);

            fill29.Append(patternFill29);

            Fill fill30 = new Fill();

            PatternFill patternFill30 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor28 = new ForegroundColor() { Theme = (UInt32Value)7U, Tint = 0.799981688894314D };
            BackgroundColor backgroundColor28 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill30.Append(foregroundColor28);
            patternFill30.Append(backgroundColor28);

            fill30.Append(patternFill30);

            Fill fill31 = new Fill();

            PatternFill patternFill31 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor29 = new ForegroundColor() { Theme = (UInt32Value)9U, Tint = 0.399975585192419D };
            BackgroundColor backgroundColor29 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill31.Append(foregroundColor29);
            patternFill31.Append(backgroundColor29);

            fill31.Append(patternFill31);

            Fill fill32 = new Fill();

            PatternFill patternFill32 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor30 = new ForegroundColor() { Theme = (UInt32Value)7U, Tint = 0.599993896298105D };
            BackgroundColor backgroundColor30 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill32.Append(foregroundColor30);
            patternFill32.Append(backgroundColor30);

            fill32.Append(patternFill32);

            Fill fill33 = new Fill();

            PatternFill patternFill33 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor31 = new ForegroundColor() { Theme = (UInt32Value)8U };
            BackgroundColor backgroundColor31 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill33.Append(foregroundColor31);
            patternFill33.Append(backgroundColor31);

            fill33.Append(patternFill33);

            Fill fill34 = new Fill();

            PatternFill patternFill34 = new PatternFill() { PatternType = PatternValues.Solid };
            ForegroundColor foregroundColor32 = new ForegroundColor() { Theme = (UInt32Value)9U };
            BackgroundColor backgroundColor32 = new BackgroundColor() { Indexed = (UInt32Value)64U };

            patternFill34.Append(foregroundColor32);
            patternFill34.Append(backgroundColor32);

            fill34.Append(patternFill34);

            fills1.Append(fill1);
            fills1.Append(fill2);
            fills1.Append(fill3);
            fills1.Append(fill4);
            fills1.Append(fill5);
            fills1.Append(fill6);
            fills1.Append(fill7);
            fills1.Append(fill8);
            fills1.Append(fill9);
            fills1.Append(fill10);
            fills1.Append(fill11);
            fills1.Append(fill12);
            fills1.Append(fill13);
            fills1.Append(fill14);
            fills1.Append(fill15);
            fills1.Append(fill16);
            fills1.Append(fill17);
            fills1.Append(fill18);
            fills1.Append(fill19);
            fills1.Append(fill20);
            fills1.Append(fill21);
            fills1.Append(fill22);
            fills1.Append(fill23);
            fills1.Append(fill24);
            fills1.Append(fill25);
            fills1.Append(fill26);
            fills1.Append(fill27);
            fills1.Append(fill28);
            fills1.Append(fill29);
            fills1.Append(fill30);
            fills1.Append(fill31);
            fills1.Append(fill32);
            fills1.Append(fill33);
            fills1.Append(fill34);

            Borders borders1 = new Borders() { Count = (UInt32Value)10U };

            Border border1 = new Border();
            LeftBorder leftBorder1 = new LeftBorder();
            RightBorder rightBorder1 = new RightBorder();
            TopBorder topBorder1 = new TopBorder();
            BottomBorder bottomBorder1 = new BottomBorder();
            DiagonalBorder diagonalBorder1 = new DiagonalBorder();

            border1.Append(leftBorder1);
            border1.Append(rightBorder1);
            border1.Append(topBorder1);
            border1.Append(bottomBorder1);
            border1.Append(diagonalBorder1);

            Border border2 = new Border();

            LeftBorder leftBorder2 = new LeftBorder() { Style = BorderStyleValues.Thin };
            Color color21 = new Color() { Auto = true };

            leftBorder2.Append(color21);

            RightBorder rightBorder2 = new RightBorder() { Style = BorderStyleValues.Thin };
            Color color22 = new Color() { Auto = true };

            rightBorder2.Append(color22);

            TopBorder topBorder2 = new TopBorder() { Style = BorderStyleValues.Thin };
            Color color23 = new Color() { Auto = true };

            topBorder2.Append(color23);

            BottomBorder bottomBorder2 = new BottomBorder() { Style = BorderStyleValues.Thin };
            Color color24 = new Color() { Auto = true };

            bottomBorder2.Append(color24);
            DiagonalBorder diagonalBorder2 = new DiagonalBorder();

            border2.Append(leftBorder2);
            border2.Append(rightBorder2);
            border2.Append(topBorder2);
            border2.Append(bottomBorder2);
            border2.Append(diagonalBorder2);

            Border border3 = new Border();

            LeftBorder leftBorder3 = new LeftBorder() { Style = BorderStyleValues.Thin };
            Color color25 = new Color() { Rgb = "FFB2B2B2" };

            leftBorder3.Append(color25);

            RightBorder rightBorder3 = new RightBorder() { Style = BorderStyleValues.Thin };
            Color color26 = new Color() { Rgb = "FFB2B2B2" };

            rightBorder3.Append(color26);

            TopBorder topBorder3 = new TopBorder() { Style = BorderStyleValues.Thin };
            Color color27 = new Color() { Rgb = "FFB2B2B2" };

            topBorder3.Append(color27);

            BottomBorder bottomBorder3 = new BottomBorder() { Style = BorderStyleValues.Thin };
            Color color28 = new Color() { Rgb = "FFB2B2B2" };

            bottomBorder3.Append(color28);
            DiagonalBorder diagonalBorder3 = new DiagonalBorder();

            border3.Append(leftBorder3);
            border3.Append(rightBorder3);
            border3.Append(topBorder3);
            border3.Append(bottomBorder3);
            border3.Append(diagonalBorder3);

            Border border4 = new Border();

            LeftBorder leftBorder4 = new LeftBorder() { Style = BorderStyleValues.Double };
            Color color29 = new Color() { Rgb = "FF3F3F3F" };

            leftBorder4.Append(color29);

            RightBorder rightBorder4 = new RightBorder() { Style = BorderStyleValues.Double };
            Color color30 = new Color() { Rgb = "FF3F3F3F" };

            rightBorder4.Append(color30);

            TopBorder topBorder4 = new TopBorder() { Style = BorderStyleValues.Double };
            Color color31 = new Color() { Rgb = "FF3F3F3F" };

            topBorder4.Append(color31);

            BottomBorder bottomBorder4 = new BottomBorder() { Style = BorderStyleValues.Double };
            Color color32 = new Color() { Rgb = "FF3F3F3F" };

            bottomBorder4.Append(color32);
            DiagonalBorder diagonalBorder4 = new DiagonalBorder();

            border4.Append(leftBorder4);
            border4.Append(rightBorder4);
            border4.Append(topBorder4);
            border4.Append(bottomBorder4);
            border4.Append(diagonalBorder4);

            Border border5 = new Border();
            LeftBorder leftBorder5 = new LeftBorder();
            RightBorder rightBorder5 = new RightBorder();
            TopBorder topBorder5 = new TopBorder();

            BottomBorder bottomBorder5 = new BottomBorder() { Style = BorderStyleValues.Medium };
            Color color33 = new Color() { Theme = (UInt32Value)4U };

            bottomBorder5.Append(color33);
            DiagonalBorder diagonalBorder5 = new DiagonalBorder();

            border5.Append(leftBorder5);
            border5.Append(rightBorder5);
            border5.Append(topBorder5);
            border5.Append(bottomBorder5);
            border5.Append(diagonalBorder5);

            Border border6 = new Border();
            LeftBorder leftBorder6 = new LeftBorder();
            RightBorder rightBorder6 = new RightBorder();

            TopBorder topBorder6 = new TopBorder() { Style = BorderStyleValues.Thin };
            Color color34 = new Color() { Theme = (UInt32Value)4U };

            topBorder6.Append(color34);

            BottomBorder bottomBorder6 = new BottomBorder() { Style = BorderStyleValues.Double };
            Color color35 = new Color() { Theme = (UInt32Value)4U };

            bottomBorder6.Append(color35);
            DiagonalBorder diagonalBorder6 = new DiagonalBorder();

            border6.Append(leftBorder6);
            border6.Append(rightBorder6);
            border6.Append(topBorder6);
            border6.Append(bottomBorder6);
            border6.Append(diagonalBorder6);

            Border border7 = new Border();
            LeftBorder leftBorder7 = new LeftBorder();
            RightBorder rightBorder7 = new RightBorder();
            TopBorder topBorder7 = new TopBorder();

            BottomBorder bottomBorder7 = new BottomBorder() { Style = BorderStyleValues.Double };
            Color color36 = new Color() { Rgb = "FFFF8001" };

            bottomBorder7.Append(color36);
            DiagonalBorder diagonalBorder7 = new DiagonalBorder();

            border7.Append(leftBorder7);
            border7.Append(rightBorder7);
            border7.Append(topBorder7);
            border7.Append(bottomBorder7);
            border7.Append(diagonalBorder7);

            Border border8 = new Border();
            LeftBorder leftBorder8 = new LeftBorder();
            RightBorder rightBorder8 = new RightBorder();
            TopBorder topBorder8 = new TopBorder();

            BottomBorder bottomBorder8 = new BottomBorder() { Style = BorderStyleValues.Medium };
            Color color37 = new Color() { Theme = (UInt32Value)4U, Tint = 0.499984740745262D };

            bottomBorder8.Append(color37);
            DiagonalBorder diagonalBorder8 = new DiagonalBorder();

            border8.Append(leftBorder8);
            border8.Append(rightBorder8);
            border8.Append(topBorder8);
            border8.Append(bottomBorder8);
            border8.Append(diagonalBorder8);

            Border border9 = new Border();

            LeftBorder leftBorder9 = new LeftBorder() { Style = BorderStyleValues.Thin };
            Color color38 = new Color() { Rgb = "FF7F7F7F" };

            leftBorder9.Append(color38);

            RightBorder rightBorder9 = new RightBorder() { Style = BorderStyleValues.Thin };
            Color color39 = new Color() { Rgb = "FF7F7F7F" };

            rightBorder9.Append(color39);

            TopBorder topBorder9 = new TopBorder() { Style = BorderStyleValues.Thin };
            Color color40 = new Color() { Rgb = "FF7F7F7F" };

            topBorder9.Append(color40);

            BottomBorder bottomBorder9 = new BottomBorder() { Style = BorderStyleValues.Thin };
            Color color41 = new Color() { Rgb = "FF7F7F7F" };

            bottomBorder9.Append(color41);
            DiagonalBorder diagonalBorder9 = new DiagonalBorder();

            border9.Append(leftBorder9);
            border9.Append(rightBorder9);
            border9.Append(topBorder9);
            border9.Append(bottomBorder9);
            border9.Append(diagonalBorder9);

            Border border10 = new Border();

            LeftBorder leftBorder10 = new LeftBorder() { Style = BorderStyleValues.Thin };
            Color color42 = new Color() { Rgb = "FF3F3F3F" };

            leftBorder10.Append(color42);

            RightBorder rightBorder10 = new RightBorder() { Style = BorderStyleValues.Thin };
            Color color43 = new Color() { Rgb = "FF3F3F3F" };

            rightBorder10.Append(color43);

            TopBorder topBorder10 = new TopBorder() { Style = BorderStyleValues.Thin };
            Color color44 = new Color() { Rgb = "FF3F3F3F" };

            topBorder10.Append(color44);

            BottomBorder bottomBorder10 = new BottomBorder() { Style = BorderStyleValues.Thin };
            Color color45 = new Color() { Rgb = "FF3F3F3F" };

            bottomBorder10.Append(color45);
            DiagonalBorder diagonalBorder10 = new DiagonalBorder();

            border10.Append(leftBorder10);
            border10.Append(rightBorder10);
            border10.Append(topBorder10);
            border10.Append(bottomBorder10);
            border10.Append(diagonalBorder10);

            borders1.Append(border1);
            borders1.Append(border2);
            borders1.Append(border3);
            borders1.Append(border4);
            borders1.Append(border5);
            borders1.Append(border6);
            borders1.Append(border7);
            borders1.Append(border8);
            borders1.Append(border9);
            borders1.Append(border10);

            CellStyleFormats cellStyleFormats1 = new CellStyleFormats() { Count = (UInt32Value)49U };

            CellFormat cellFormat1 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U };
            Alignment alignment1 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat1.Append(alignment1);

            CellFormat cellFormat2 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)2U, FillId = (UInt32Value)5U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment2 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat2.Append(alignment2);

            CellFormat cellFormat3 = new CellFormat() { NumberFormatId = (UInt32Value)178U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, ApplyFont = false, ApplyFill = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment3 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat3.Append(alignment3);

            CellFormat cellFormat4 = new CellFormat() { NumberFormatId = (UInt32Value)179U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, ApplyFont = false, ApplyFill = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment4 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat4.Append(alignment4);

            CellFormat cellFormat5 = new CellFormat() { NumberFormatId = (UInt32Value)42U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, ApplyFont = false, ApplyFill = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment5 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat5.Append(alignment5);

            CellFormat cellFormat6 = new CellFormat() { NumberFormatId = (UInt32Value)44U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, ApplyFont = false, ApplyFill = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment6 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat6.Append(alignment6);

            CellFormat cellFormat7 = new CellFormat() { NumberFormatId = (UInt32Value)9U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, ApplyFont = false, ApplyFill = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment7 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat7.Append(alignment7);

            CellFormat cellFormat8 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)3U, FillId = (UInt32Value)6U, BorderId = (UInt32Value)3U, ApplyNumberFormat = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment8 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat8.Append(alignment8);

            CellFormat cellFormat9 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)4U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)4U, ApplyNumberFormat = false, ApplyFill = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment9 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat9.Append(alignment9);

            CellFormat cellFormat10 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)3U, BorderId = (UInt32Value)2U, ApplyNumberFormat = false, ApplyFont = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment10 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat10.Append(alignment10);

            CellFormat cellFormat11 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)5U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyFill = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment11 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat11.Append(alignment11);

            CellFormat cellFormat12 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)6U, FillId = (UInt32Value)8U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment12 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat12.Append(alignment12);

            CellFormat cellFormat13 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)8U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyFill = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment13 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat13.Append(alignment13);

            CellFormat cellFormat14 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)2U, FillId = (UInt32Value)10U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment14 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat14.Append(alignment14);

            CellFormat cellFormat15 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)11U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyFill = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment15 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat15.Append(alignment15);

            CellFormat cellFormat16 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)2U, FillId = (UInt32Value)11U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment16 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat16.Append(alignment16);

            CellFormat cellFormat17 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)10U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyFill = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment17 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat17.Append(alignment17);

            CellFormat cellFormat18 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)7U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyFill = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment18 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat18.Append(alignment18);

            CellFormat cellFormat19 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)14U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)4U, ApplyNumberFormat = false, ApplyFill = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment19 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat19.Append(alignment19);

            CellFormat cellFormat20 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)13U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)7U, ApplyNumberFormat = false, ApplyFill = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment20 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat20.Append(alignment20);

            CellFormat cellFormat21 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)13U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyFill = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment21 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat21.Append(alignment21);

            CellFormat cellFormat22 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)15U, FillId = (UInt32Value)15U, BorderId = (UInt32Value)8U, ApplyNumberFormat = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment22 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat22.Append(alignment22);

            CellFormat cellFormat23 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)6U, FillId = (UInt32Value)17U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment23 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat23.Append(alignment23);

            CellFormat cellFormat24 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)1U, FillId = (UInt32Value)4U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment24 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat24.Append(alignment24);

            CellFormat cellFormat25 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)16U, FillId = (UInt32Value)18U, BorderId = (UInt32Value)9U, ApplyNumberFormat = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment25 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat25.Append(alignment25);

            CellFormat cellFormat26 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)2U, FillId = (UInt32Value)9U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment26 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat26.Append(alignment26);

            CellFormat cellFormat27 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)17U, FillId = (UInt32Value)18U, BorderId = (UInt32Value)8U, ApplyNumberFormat = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment27 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat27.Append(alignment27);

            CellFormat cellFormat28 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)12U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)6U, ApplyNumberFormat = false, ApplyFill = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment28 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat28.Append(alignment28);

            CellFormat cellFormat29 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)9U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)5U, ApplyNumberFormat = false, ApplyFill = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment29 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat29.Append(alignment29);

            CellFormat cellFormat30 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)19U, FillId = (UInt32Value)20U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment30 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat30.Append(alignment30);

            CellFormat cellFormat31 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)18U, FillId = (UInt32Value)19U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment31 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat31.Append(alignment31);

            CellFormat cellFormat32 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)6U, FillId = (UInt32Value)21U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment32 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat32.Append(alignment32);

            CellFormat cellFormat33 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)2U, FillId = (UInt32Value)7U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment33 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat33.Append(alignment33);

            CellFormat cellFormat34 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)6U, FillId = (UInt32Value)14U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment34 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat34.Append(alignment34);

            CellFormat cellFormat35 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)6U, FillId = (UInt32Value)24U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment35 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat35.Append(alignment35);

            CellFormat cellFormat36 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)2U, FillId = (UInt32Value)23U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment36 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat36.Append(alignment36);

            CellFormat cellFormat37 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)2U, FillId = (UInt32Value)26U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment37 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat37.Append(alignment37);

            CellFormat cellFormat38 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)6U, FillId = (UInt32Value)12U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment38 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat38.Append(alignment38);

            CellFormat cellFormat39 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)6U, FillId = (UInt32Value)22U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment39 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat39.Append(alignment39);

            CellFormat cellFormat40 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)2U, FillId = (UInt32Value)13U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment40 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat40.Append(alignment40);

            CellFormat cellFormat41 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)6U, FillId = (UInt32Value)28U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment41 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat41.Append(alignment41);

            CellFormat cellFormat42 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)2U, FillId = (UInt32Value)29U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment42 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat42.Append(alignment42);

            CellFormat cellFormat43 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)2U, FillId = (UInt32Value)31U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment43 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat43.Append(alignment43);

            CellFormat cellFormat44 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)6U, FillId = (UInt32Value)32U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment44 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat44.Append(alignment44);

            CellFormat cellFormat45 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)2U, FillId = (UInt32Value)16U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment45 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat45.Append(alignment45);

            CellFormat cellFormat46 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)6U, FillId = (UInt32Value)25U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment46 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat46.Append(alignment46);

            CellFormat cellFormat47 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)6U, FillId = (UInt32Value)33U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment47 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat47.Append(alignment47);

            CellFormat cellFormat48 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)2U, FillId = (UInt32Value)27U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment48 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat48.Append(alignment48);

            CellFormat cellFormat49 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)6U, FillId = (UInt32Value)30U, BorderId = (UInt32Value)0U, ApplyNumberFormat = false, ApplyBorder = false, ApplyAlignment = false, ApplyProtection = false };
            Alignment alignment49 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat49.Append(alignment49);

            cellStyleFormats1.Append(cellFormat1);
            cellStyleFormats1.Append(cellFormat2);
            cellStyleFormats1.Append(cellFormat3);
            cellStyleFormats1.Append(cellFormat4);
            cellStyleFormats1.Append(cellFormat5);
            cellStyleFormats1.Append(cellFormat6);
            cellStyleFormats1.Append(cellFormat7);
            cellStyleFormats1.Append(cellFormat8);
            cellStyleFormats1.Append(cellFormat9);
            cellStyleFormats1.Append(cellFormat10);
            cellStyleFormats1.Append(cellFormat11);
            cellStyleFormats1.Append(cellFormat12);
            cellStyleFormats1.Append(cellFormat13);
            cellStyleFormats1.Append(cellFormat14);
            cellStyleFormats1.Append(cellFormat15);
            cellStyleFormats1.Append(cellFormat16);
            cellStyleFormats1.Append(cellFormat17);
            cellStyleFormats1.Append(cellFormat18);
            cellStyleFormats1.Append(cellFormat19);
            cellStyleFormats1.Append(cellFormat20);
            cellStyleFormats1.Append(cellFormat21);
            cellStyleFormats1.Append(cellFormat22);
            cellStyleFormats1.Append(cellFormat23);
            cellStyleFormats1.Append(cellFormat24);
            cellStyleFormats1.Append(cellFormat25);
            cellStyleFormats1.Append(cellFormat26);
            cellStyleFormats1.Append(cellFormat27);
            cellStyleFormats1.Append(cellFormat28);
            cellStyleFormats1.Append(cellFormat29);
            cellStyleFormats1.Append(cellFormat30);
            cellStyleFormats1.Append(cellFormat31);
            cellStyleFormats1.Append(cellFormat32);
            cellStyleFormats1.Append(cellFormat33);
            cellStyleFormats1.Append(cellFormat34);
            cellStyleFormats1.Append(cellFormat35);
            cellStyleFormats1.Append(cellFormat36);
            cellStyleFormats1.Append(cellFormat37);
            cellStyleFormats1.Append(cellFormat38);
            cellStyleFormats1.Append(cellFormat39);
            cellStyleFormats1.Append(cellFormat40);
            cellStyleFormats1.Append(cellFormat41);
            cellStyleFormats1.Append(cellFormat42);
            cellStyleFormats1.Append(cellFormat43);
            cellStyleFormats1.Append(cellFormat44);
            cellStyleFormats1.Append(cellFormat45);
            cellStyleFormats1.Append(cellFormat46);
            cellStyleFormats1.Append(cellFormat47);
            cellStyleFormats1.Append(cellFormat48);
            cellStyleFormats1.Append(cellFormat49);

            CellFormats cellFormats1 = new CellFormats() { Count = (UInt32Value)6U };

            CellFormat cellFormat50 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U };
            Alignment alignment50 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat50.Append(alignment50);

            CellFormat cellFormat51 = new CellFormat() { NumberFormatId = (UInt32Value)22U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U, ApplyNumberFormat = true };
            Alignment alignment51 = new Alignment() { Vertical = VerticalAlignmentValues.Center };

            cellFormat51.Append(alignment51);

            CellFormat cellFormat52 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)2U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyFill = true, ApplyBorder = true, ApplyAlignment = true };
            Alignment alignment52 = new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center };

            cellFormat52.Append(alignment52);

            CellFormat cellFormat53 = new CellFormat() { NumberFormatId = (UInt32Value)177U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyNumberFormat = true, ApplyBorder = true, ApplyAlignment = true };
            Alignment alignment53 = new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center };

            cellFormat53.Append(alignment53);

            CellFormat cellFormat54 = new CellFormat() { NumberFormatId = (UInt32Value)176U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyNumberFormat = true, ApplyBorder = true, ApplyAlignment = true };
            Alignment alignment54 = new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center };

            cellFormat54.Append(alignment54);

            CellFormat cellFormat55 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyBorder = true, ApplyAlignment = true };
            Alignment alignment55 = new Alignment() { Horizontal = HorizontalAlignmentValues.Center, Vertical = VerticalAlignmentValues.Center };

            cellFormat55.Append(alignment55);

            cellFormats1.Append(cellFormat50);
            cellFormats1.Append(cellFormat51);
            cellFormats1.Append(cellFormat52);
            cellFormats1.Append(cellFormat53);
            cellFormats1.Append(cellFormat54);
            cellFormats1.Append(cellFormat55);

            CellStyles cellStyles1 = new CellStyles() { Count = (UInt32Value)49U };
            CellStyle cellStyle1 = new CellStyle() { Name = "Normal", FormatId = (UInt32Value)0U, BuiltinId = (UInt32Value)0U };
            CellStyle cellStyle2 = new CellStyle() { Name = "40% - Accent1", FormatId = (UInt32Value)1U, BuiltinId = (UInt32Value)31U };
            CellStyle cellStyle3 = new CellStyle() { Name = "Comma", FormatId = (UInt32Value)2U, BuiltinId = (UInt32Value)3U };
            CellStyle cellStyle4 = new CellStyle() { Name = "Comma [0]", FormatId = (UInt32Value)3U, BuiltinId = (UInt32Value)6U };
            CellStyle cellStyle5 = new CellStyle() { Name = "Currency [0]", FormatId = (UInt32Value)4U, BuiltinId = (UInt32Value)7U };
            CellStyle cellStyle6 = new CellStyle() { Name = "Currency", FormatId = (UInt32Value)5U, BuiltinId = (UInt32Value)4U };
            CellStyle cellStyle7 = new CellStyle() { Name = "Percent", FormatId = (UInt32Value)6U, BuiltinId = (UInt32Value)5U };
            CellStyle cellStyle8 = new CellStyle() { Name = "Check Cell", FormatId = (UInt32Value)7U, BuiltinId = (UInt32Value)23U };
            CellStyle cellStyle9 = new CellStyle() { Name = "Heading 2", FormatId = (UInt32Value)8U, BuiltinId = (UInt32Value)17U };
            CellStyle cellStyle10 = new CellStyle() { Name = "Note", FormatId = (UInt32Value)9U, BuiltinId = (UInt32Value)10U };
            CellStyle cellStyle11 = new CellStyle() { Name = "Hyperlink", FormatId = (UInt32Value)10U, BuiltinId = (UInt32Value)8U };
            CellStyle cellStyle12 = new CellStyle() { Name = "60% - Accent4", FormatId = (UInt32Value)11U, BuiltinId = (UInt32Value)44U };
            CellStyle cellStyle13 = new CellStyle() { Name = "Followed Hyperlink", FormatId = (UInt32Value)12U, BuiltinId = (UInt32Value)9U };
            CellStyle cellStyle14 = new CellStyle() { Name = "40% - Accent3", FormatId = (UInt32Value)13U, BuiltinId = (UInt32Value)39U };
            CellStyle cellStyle15 = new CellStyle() { Name = "Warning Text", FormatId = (UInt32Value)14U, BuiltinId = (UInt32Value)11U };
            CellStyle cellStyle16 = new CellStyle() { Name = "40% - Accent2", FormatId = (UInt32Value)15U, BuiltinId = (UInt32Value)35U };
            CellStyle cellStyle17 = new CellStyle() { Name = "Title", FormatId = (UInt32Value)16U, BuiltinId = (UInt32Value)15U };
            CellStyle cellStyle18 = new CellStyle() { Name = "CExplanatory Text", FormatId = (UInt32Value)17U, BuiltinId = (UInt32Value)53U };
            CellStyle cellStyle19 = new CellStyle() { Name = "Heading 1", FormatId = (UInt32Value)18U, BuiltinId = (UInt32Value)16U };
            CellStyle cellStyle20 = new CellStyle() { Name = "Heading 3", FormatId = (UInt32Value)19U, BuiltinId = (UInt32Value)18U };
            CellStyle cellStyle21 = new CellStyle() { Name = "Heading 4", FormatId = (UInt32Value)20U, BuiltinId = (UInt32Value)19U };
            CellStyle cellStyle22 = new CellStyle() { Name = "Input", FormatId = (UInt32Value)21U, BuiltinId = (UInt32Value)20U };
            CellStyle cellStyle23 = new CellStyle() { Name = "60% - Accent3", FormatId = (UInt32Value)22U, BuiltinId = (UInt32Value)40U };
            CellStyle cellStyle24 = new CellStyle() { Name = "Good", FormatId = (UInt32Value)23U, BuiltinId = (UInt32Value)26U };
            CellStyle cellStyle25 = new CellStyle() { Name = "Output", FormatId = (UInt32Value)24U, BuiltinId = (UInt32Value)21U };
            CellStyle cellStyle26 = new CellStyle() { Name = "20% - Accent1", FormatId = (UInt32Value)25U, BuiltinId = (UInt32Value)30U };
            CellStyle cellStyle27 = new CellStyle() { Name = "Calculation", FormatId = (UInt32Value)26U, BuiltinId = (UInt32Value)22U };
            CellStyle cellStyle28 = new CellStyle() { Name = "Linked Cell", FormatId = (UInt32Value)27U, BuiltinId = (UInt32Value)24U };
            CellStyle cellStyle29 = new CellStyle() { Name = "Total", FormatId = (UInt32Value)28U, BuiltinId = (UInt32Value)25U };
            CellStyle cellStyle30 = new CellStyle() { Name = "Bad", FormatId = (UInt32Value)29U, BuiltinId = (UInt32Value)27U };
            CellStyle cellStyle31 = new CellStyle() { Name = "Neutral", FormatId = (UInt32Value)30U, BuiltinId = (UInt32Value)28U };
            CellStyle cellStyle32 = new CellStyle() { Name = "Accent1", FormatId = (UInt32Value)31U, BuiltinId = (UInt32Value)29U };
            CellStyle cellStyle33 = new CellStyle() { Name = "20% - Accent5", FormatId = (UInt32Value)32U, BuiltinId = (UInt32Value)46U };
            CellStyle cellStyle34 = new CellStyle() { Name = "60% - Accent1", FormatId = (UInt32Value)33U, BuiltinId = (UInt32Value)32U };
            CellStyle cellStyle35 = new CellStyle() { Name = "Accent2", FormatId = (UInt32Value)34U, BuiltinId = (UInt32Value)33U };
            CellStyle cellStyle36 = new CellStyle() { Name = "20% - Accent2", FormatId = (UInt32Value)35U, BuiltinId = (UInt32Value)34U };
            CellStyle cellStyle37 = new CellStyle() { Name = "20% - Accent6", FormatId = (UInt32Value)36U, BuiltinId = (UInt32Value)50U };
            CellStyle cellStyle38 = new CellStyle() { Name = "60% - Accent2", FormatId = (UInt32Value)37U, BuiltinId = (UInt32Value)36U };
            CellStyle cellStyle39 = new CellStyle() { Name = "Accent3", FormatId = (UInt32Value)38U, BuiltinId = (UInt32Value)37U };
            CellStyle cellStyle40 = new CellStyle() { Name = "20% - Accent3", FormatId = (UInt32Value)39U, BuiltinId = (UInt32Value)38U };
            CellStyle cellStyle41 = new CellStyle() { Name = "Accent4", FormatId = (UInt32Value)40U, BuiltinId = (UInt32Value)41U };
            CellStyle cellStyle42 = new CellStyle() { Name = "20% - Accent4", FormatId = (UInt32Value)41U, BuiltinId = (UInt32Value)42U };
            CellStyle cellStyle43 = new CellStyle() { Name = "40% - Accent4", FormatId = (UInt32Value)42U, BuiltinId = (UInt32Value)43U };
            CellStyle cellStyle44 = new CellStyle() { Name = "Accent5", FormatId = (UInt32Value)43U, BuiltinId = (UInt32Value)45U };
            CellStyle cellStyle45 = new CellStyle() { Name = "40% - Accent5", FormatId = (UInt32Value)44U, BuiltinId = (UInt32Value)47U };
            CellStyle cellStyle46 = new CellStyle() { Name = "60% - Accent5", FormatId = (UInt32Value)45U, BuiltinId = (UInt32Value)48U };
            CellStyle cellStyle47 = new CellStyle() { Name = "Accent6", FormatId = (UInt32Value)46U, BuiltinId = (UInt32Value)49U };
            CellStyle cellStyle48 = new CellStyle() { Name = "40% - Accent6", FormatId = (UInt32Value)47U, BuiltinId = (UInt32Value)51U };
            CellStyle cellStyle49 = new CellStyle() { Name = "60% - Accent6", FormatId = (UInt32Value)48U, BuiltinId = (UInt32Value)52U };

            cellStyles1.Append(cellStyle1);
            cellStyles1.Append(cellStyle2);
            cellStyles1.Append(cellStyle3);
            cellStyles1.Append(cellStyle4);
            cellStyles1.Append(cellStyle5);
            cellStyles1.Append(cellStyle6);
            cellStyles1.Append(cellStyle7);
            cellStyles1.Append(cellStyle8);
            cellStyles1.Append(cellStyle9);
            cellStyles1.Append(cellStyle10);
            cellStyles1.Append(cellStyle11);
            cellStyles1.Append(cellStyle12);
            cellStyles1.Append(cellStyle13);
            cellStyles1.Append(cellStyle14);
            cellStyles1.Append(cellStyle15);
            cellStyles1.Append(cellStyle16);
            cellStyles1.Append(cellStyle17);
            cellStyles1.Append(cellStyle18);
            cellStyles1.Append(cellStyle19);
            cellStyles1.Append(cellStyle20);
            cellStyles1.Append(cellStyle21);
            cellStyles1.Append(cellStyle22);
            cellStyles1.Append(cellStyle23);
            cellStyles1.Append(cellStyle24);
            cellStyles1.Append(cellStyle25);
            cellStyles1.Append(cellStyle26);
            cellStyles1.Append(cellStyle27);
            cellStyles1.Append(cellStyle28);
            cellStyles1.Append(cellStyle29);
            cellStyles1.Append(cellStyle30);
            cellStyles1.Append(cellStyle31);
            cellStyles1.Append(cellStyle32);
            cellStyles1.Append(cellStyle33);
            cellStyles1.Append(cellStyle34);
            cellStyles1.Append(cellStyle35);
            cellStyles1.Append(cellStyle36);
            cellStyles1.Append(cellStyle37);
            cellStyles1.Append(cellStyle38);
            cellStyles1.Append(cellStyle39);
            cellStyles1.Append(cellStyle40);
            cellStyles1.Append(cellStyle41);
            cellStyles1.Append(cellStyle42);
            cellStyles1.Append(cellStyle43);
            cellStyles1.Append(cellStyle44);
            cellStyles1.Append(cellStyle45);
            cellStyles1.Append(cellStyle46);
            cellStyles1.Append(cellStyle47);
            cellStyles1.Append(cellStyle48);
            cellStyles1.Append(cellStyle49);
            TableStyles tableStyles1 = new TableStyles() { Count = (UInt32Value)0U, DefaultTableStyle = "TableStyleMedium2", DefaultPivotStyle = "PivotStyleLight16" };

            StylesheetExtensionList stylesheetExtensionList1 = new StylesheetExtensionList();

            StylesheetExtension stylesheetExtension1 = new StylesheetExtension() { Uri = "{EB79DEF2-80B8-43e5-95BD-54CBDDF9020C}" };
            stylesheetExtension1.AddNamespaceDeclaration("x14", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main");
            X14.SlicerStyles slicerStyles1 = new X14.SlicerStyles() { DefaultSlicerStyle = "SlicerStyleLight1" };

            stylesheetExtension1.Append(slicerStyles1);

            stylesheetExtensionList1.Append(stylesheetExtension1);

            stylesheet1.Append(numberingFormats1);
            stylesheet1.Append(fonts1);
            stylesheet1.Append(fills1);
            stylesheet1.Append(borders1);
            stylesheet1.Append(cellStyleFormats1);
            stylesheet1.Append(cellFormats1);
            stylesheet1.Append(cellStyles1);
            stylesheet1.Append(tableStyles1);
            stylesheet1.Append(stylesheetExtensionList1);

            workbookStylesPart1.Stylesheet = stylesheet1;
        }

        // Generates content of themePart1.
        private void GenerateThemePart1Content(ThemePart themePart1)
        {
            A.Theme theme1 = new A.Theme() { Name = "Office" };
            theme1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.ThemeElements themeElements1 = new A.ThemeElements();

            A.ColorScheme colorScheme1 = new A.ColorScheme() { Name = "Office" };

            A.Dark1Color dark1Color1 = new A.Dark1Color();
            A.SystemColor systemColor1 = new A.SystemColor() { Val = A.SystemColorValues.WindowText, LastColor = "000000" };

            dark1Color1.Append(systemColor1);

            A.Light1Color light1Color1 = new A.Light1Color();
            A.SystemColor systemColor2 = new A.SystemColor() { Val = A.SystemColorValues.Window, LastColor = "FFFFFF" };

            light1Color1.Append(systemColor2);

            A.Dark2Color dark2Color1 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex1 = new A.RgbColorModelHex() { Val = "44546A" };

            dark2Color1.Append(rgbColorModelHex1);

            A.Light2Color light2Color1 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex2 = new A.RgbColorModelHex() { Val = "E7E6E6" };

            light2Color1.Append(rgbColorModelHex2);

            A.Accent1Color accent1Color1 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex3 = new A.RgbColorModelHex() { Val = "5B9BD5" };

            accent1Color1.Append(rgbColorModelHex3);

            A.Accent2Color accent2Color1 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex4 = new A.RgbColorModelHex() { Val = "ED7D31" };

            accent2Color1.Append(rgbColorModelHex4);

            A.Accent3Color accent3Color1 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex5 = new A.RgbColorModelHex() { Val = "A5A5A5" };

            accent3Color1.Append(rgbColorModelHex5);

            A.Accent4Color accent4Color1 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex6 = new A.RgbColorModelHex() { Val = "FFC000" };

            accent4Color1.Append(rgbColorModelHex6);

            A.Accent5Color accent5Color1 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex7 = new A.RgbColorModelHex() { Val = "4472C4" };

            accent5Color1.Append(rgbColorModelHex7);

            A.Accent6Color accent6Color1 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex8 = new A.RgbColorModelHex() { Val = "70AD47" };

            accent6Color1.Append(rgbColorModelHex8);

            A.Hyperlink hyperlink1 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex9 = new A.RgbColorModelHex() { Val = "0563C1" };

            hyperlink1.Append(rgbColorModelHex9);

            A.FollowedHyperlinkColor followedHyperlinkColor1 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex10 = new A.RgbColorModelHex() { Val = "954F72" };

            followedHyperlinkColor1.Append(rgbColorModelHex10);

            colorScheme1.Append(dark1Color1);
            colorScheme1.Append(light1Color1);
            colorScheme1.Append(dark2Color1);
            colorScheme1.Append(light2Color1);
            colorScheme1.Append(accent1Color1);
            colorScheme1.Append(accent2Color1);
            colorScheme1.Append(accent3Color1);
            colorScheme1.Append(accent4Color1);
            colorScheme1.Append(accent5Color1);
            colorScheme1.Append(accent6Color1);
            colorScheme1.Append(hyperlink1);
            colorScheme1.Append(followedHyperlinkColor1);

            A.FontScheme fontScheme21 = new A.FontScheme() { Name = "Office" };

            A.MajorFont majorFont1 = new A.MajorFont();
            A.LatinFont latinFont1 = new A.LatinFont() { Typeface = "Calibri Light" };
            A.EastAsianFont eastAsianFont1 = new A.EastAsianFont() { Typeface = "" };
            A.ComplexScriptFont complexScriptFont1 = new A.ComplexScriptFont() { Typeface = "" };
            A.SupplementalFont supplementalFont1 = new A.SupplementalFont() { Script = "Jpan", Typeface = "ＭＳ Ｐゴシック" };
            A.SupplementalFont supplementalFont2 = new A.SupplementalFont() { Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont3 = new A.SupplementalFont() { Script = "Hans", Typeface = "宋体" };
            A.SupplementalFont supplementalFont4 = new A.SupplementalFont() { Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont5 = new A.SupplementalFont() { Script = "Arab", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont6 = new A.SupplementalFont() { Script = "Hebr", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont7 = new A.SupplementalFont() { Script = "Thai", Typeface = "Tahoma" };
            A.SupplementalFont supplementalFont8 = new A.SupplementalFont() { Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont9 = new A.SupplementalFont() { Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont10 = new A.SupplementalFont() { Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont11 = new A.SupplementalFont() { Script = "Khmr", Typeface = "MoolBoran" };
            A.SupplementalFont supplementalFont12 = new A.SupplementalFont() { Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont13 = new A.SupplementalFont() { Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont14 = new A.SupplementalFont() { Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont15 = new A.SupplementalFont() { Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont16 = new A.SupplementalFont() { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont17 = new A.SupplementalFont() { Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont18 = new A.SupplementalFont() { Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont19 = new A.SupplementalFont() { Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont20 = new A.SupplementalFont() { Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont21 = new A.SupplementalFont() { Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont22 = new A.SupplementalFont() { Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont23 = new A.SupplementalFont() { Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont24 = new A.SupplementalFont() { Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont25 = new A.SupplementalFont() { Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont26 = new A.SupplementalFont() { Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont27 = new A.SupplementalFont() { Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont28 = new A.SupplementalFont() { Script = "Viet", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont29 = new A.SupplementalFont() { Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont30 = new A.SupplementalFont() { Script = "Geor", Typeface = "Sylfaen" };

            majorFont1.Append(latinFont1);
            majorFont1.Append(eastAsianFont1);
            majorFont1.Append(complexScriptFont1);
            majorFont1.Append(supplementalFont1);
            majorFont1.Append(supplementalFont2);
            majorFont1.Append(supplementalFont3);
            majorFont1.Append(supplementalFont4);
            majorFont1.Append(supplementalFont5);
            majorFont1.Append(supplementalFont6);
            majorFont1.Append(supplementalFont7);
            majorFont1.Append(supplementalFont8);
            majorFont1.Append(supplementalFont9);
            majorFont1.Append(supplementalFont10);
            majorFont1.Append(supplementalFont11);
            majorFont1.Append(supplementalFont12);
            majorFont1.Append(supplementalFont13);
            majorFont1.Append(supplementalFont14);
            majorFont1.Append(supplementalFont15);
            majorFont1.Append(supplementalFont16);
            majorFont1.Append(supplementalFont17);
            majorFont1.Append(supplementalFont18);
            majorFont1.Append(supplementalFont19);
            majorFont1.Append(supplementalFont20);
            majorFont1.Append(supplementalFont21);
            majorFont1.Append(supplementalFont22);
            majorFont1.Append(supplementalFont23);
            majorFont1.Append(supplementalFont24);
            majorFont1.Append(supplementalFont25);
            majorFont1.Append(supplementalFont26);
            majorFont1.Append(supplementalFont27);
            majorFont1.Append(supplementalFont28);
            majorFont1.Append(supplementalFont29);
            majorFont1.Append(supplementalFont30);

            A.MinorFont minorFont1 = new A.MinorFont();
            A.LatinFont latinFont2 = new A.LatinFont() { Typeface = "Calibri" };
            A.EastAsianFont eastAsianFont2 = new A.EastAsianFont() { Typeface = "" };
            A.ComplexScriptFont complexScriptFont2 = new A.ComplexScriptFont() { Typeface = "" };
            A.SupplementalFont supplementalFont31 = new A.SupplementalFont() { Script = "Jpan", Typeface = "ＭＳ Ｐゴシック" };
            A.SupplementalFont supplementalFont32 = new A.SupplementalFont() { Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont33 = new A.SupplementalFont() { Script = "Hans", Typeface = "宋体" };
            A.SupplementalFont supplementalFont34 = new A.SupplementalFont() { Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont35 = new A.SupplementalFont() { Script = "Arab", Typeface = "Arial" };
            A.SupplementalFont supplementalFont36 = new A.SupplementalFont() { Script = "Hebr", Typeface = "Arial" };
            A.SupplementalFont supplementalFont37 = new A.SupplementalFont() { Script = "Thai", Typeface = "Tahoma" };
            A.SupplementalFont supplementalFont38 = new A.SupplementalFont() { Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont39 = new A.SupplementalFont() { Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont40 = new A.SupplementalFont() { Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont41 = new A.SupplementalFont() { Script = "Khmr", Typeface = "DaunPenh" };
            A.SupplementalFont supplementalFont42 = new A.SupplementalFont() { Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont43 = new A.SupplementalFont() { Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont44 = new A.SupplementalFont() { Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont45 = new A.SupplementalFont() { Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont46 = new A.SupplementalFont() { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont47 = new A.SupplementalFont() { Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont48 = new A.SupplementalFont() { Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont49 = new A.SupplementalFont() { Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont50 = new A.SupplementalFont() { Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont51 = new A.SupplementalFont() { Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont52 = new A.SupplementalFont() { Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont53 = new A.SupplementalFont() { Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont54 = new A.SupplementalFont() { Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont55 = new A.SupplementalFont() { Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont56 = new A.SupplementalFont() { Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont57 = new A.SupplementalFont() { Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont58 = new A.SupplementalFont() { Script = "Viet", Typeface = "Arial" };
            A.SupplementalFont supplementalFont59 = new A.SupplementalFont() { Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont60 = new A.SupplementalFont() { Script = "Geor", Typeface = "Sylfaen" };

            minorFont1.Append(latinFont2);
            minorFont1.Append(eastAsianFont2);
            minorFont1.Append(complexScriptFont2);
            minorFont1.Append(supplementalFont31);
            minorFont1.Append(supplementalFont32);
            minorFont1.Append(supplementalFont33);
            minorFont1.Append(supplementalFont34);
            minorFont1.Append(supplementalFont35);
            minorFont1.Append(supplementalFont36);
            minorFont1.Append(supplementalFont37);
            minorFont1.Append(supplementalFont38);
            minorFont1.Append(supplementalFont39);
            minorFont1.Append(supplementalFont40);
            minorFont1.Append(supplementalFont41);
            minorFont1.Append(supplementalFont42);
            minorFont1.Append(supplementalFont43);
            minorFont1.Append(supplementalFont44);
            minorFont1.Append(supplementalFont45);
            minorFont1.Append(supplementalFont46);
            minorFont1.Append(supplementalFont47);
            minorFont1.Append(supplementalFont48);
            minorFont1.Append(supplementalFont49);
            minorFont1.Append(supplementalFont50);
            minorFont1.Append(supplementalFont51);
            minorFont1.Append(supplementalFont52);
            minorFont1.Append(supplementalFont53);
            minorFont1.Append(supplementalFont54);
            minorFont1.Append(supplementalFont55);
            minorFont1.Append(supplementalFont56);
            minorFont1.Append(supplementalFont57);
            minorFont1.Append(supplementalFont58);
            minorFont1.Append(supplementalFont59);
            minorFont1.Append(supplementalFont60);

            fontScheme21.Append(majorFont1);
            fontScheme21.Append(minorFont1);

            A.FormatScheme formatScheme1 = new A.FormatScheme() { Name = "Office" };

            A.FillStyleList fillStyleList1 = new A.FillStyleList();

            A.SolidFill solidFill1 = new A.SolidFill();
            A.SchemeColor schemeColor1 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill1.Append(schemeColor1);

            A.GradientFill gradientFill1 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList1 = new A.GradientStopList();

            A.GradientStop gradientStop1 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor2 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation1 = new A.LuminanceModulation() { Val = 110000 };
            A.SaturationModulation saturationModulation1 = new A.SaturationModulation() { Val = 105000 };
            A.Tint tint1 = new A.Tint() { Val = 67000 };

            schemeColor2.Append(luminanceModulation1);
            schemeColor2.Append(saturationModulation1);
            schemeColor2.Append(tint1);

            gradientStop1.Append(schemeColor2);

            A.GradientStop gradientStop2 = new A.GradientStop() { Position = 50000 };

            A.SchemeColor schemeColor3 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation2 = new A.LuminanceModulation() { Val = 105000 };
            A.SaturationModulation saturationModulation2 = new A.SaturationModulation() { Val = 103000 };
            A.Tint tint2 = new A.Tint() { Val = 73000 };

            schemeColor3.Append(luminanceModulation2);
            schemeColor3.Append(saturationModulation2);
            schemeColor3.Append(tint2);

            gradientStop2.Append(schemeColor3);

            A.GradientStop gradientStop3 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor4 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation3 = new A.LuminanceModulation() { Val = 105000 };
            A.SaturationModulation saturationModulation3 = new A.SaturationModulation() { Val = 109000 };
            A.Tint tint3 = new A.Tint() { Val = 81000 };

            schemeColor4.Append(luminanceModulation3);
            schemeColor4.Append(saturationModulation3);
            schemeColor4.Append(tint3);

            gradientStop3.Append(schemeColor4);

            gradientStopList1.Append(gradientStop1);
            gradientStopList1.Append(gradientStop2);
            gradientStopList1.Append(gradientStop3);
            A.LinearGradientFill linearGradientFill1 = new A.LinearGradientFill() { Angle = 5400000, Scaled = false };

            gradientFill1.Append(gradientStopList1);
            gradientFill1.Append(linearGradientFill1);

            A.GradientFill gradientFill2 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList2 = new A.GradientStopList();

            A.GradientStop gradientStop4 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor5 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.SaturationModulation saturationModulation4 = new A.SaturationModulation() { Val = 103000 };
            A.LuminanceModulation luminanceModulation4 = new A.LuminanceModulation() { Val = 102000 };
            A.Tint tint4 = new A.Tint() { Val = 94000 };

            schemeColor5.Append(saturationModulation4);
            schemeColor5.Append(luminanceModulation4);
            schemeColor5.Append(tint4);

            gradientStop4.Append(schemeColor5);

            A.GradientStop gradientStop5 = new A.GradientStop() { Position = 50000 };

            A.SchemeColor schemeColor6 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.SaturationModulation saturationModulation5 = new A.SaturationModulation() { Val = 110000 };
            A.LuminanceModulation luminanceModulation5 = new A.LuminanceModulation() { Val = 100000 };
            A.Shade shade1 = new A.Shade() { Val = 100000 };

            schemeColor6.Append(saturationModulation5);
            schemeColor6.Append(luminanceModulation5);
            schemeColor6.Append(shade1);

            gradientStop5.Append(schemeColor6);

            A.GradientStop gradientStop6 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor7 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation6 = new A.LuminanceModulation() { Val = 99000 };
            A.SaturationModulation saturationModulation6 = new A.SaturationModulation() { Val = 120000 };
            A.Shade shade2 = new A.Shade() { Val = 78000 };

            schemeColor7.Append(luminanceModulation6);
            schemeColor7.Append(saturationModulation6);
            schemeColor7.Append(shade2);

            gradientStop6.Append(schemeColor7);

            gradientStopList2.Append(gradientStop4);
            gradientStopList2.Append(gradientStop5);
            gradientStopList2.Append(gradientStop6);
            A.LinearGradientFill linearGradientFill2 = new A.LinearGradientFill() { Angle = 5400000, Scaled = false };

            gradientFill2.Append(gradientStopList2);
            gradientFill2.Append(linearGradientFill2);

            fillStyleList1.Append(solidFill1);
            fillStyleList1.Append(gradientFill1);
            fillStyleList1.Append(gradientFill2);

            A.LineStyleList lineStyleList1 = new A.LineStyleList();

            A.Outline outline1 = new A.Outline() { Width = 6350, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill2 = new A.SolidFill();
            A.SchemeColor schemeColor8 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill2.Append(schemeColor8);
            A.PresetDash presetDash1 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };
            A.Miter miter1 = new A.Miter() { Limit = 800000 };

            outline1.Append(solidFill2);
            outline1.Append(presetDash1);
            outline1.Append(miter1);

            A.Outline outline2 = new A.Outline() { Width = 12700, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill3 = new A.SolidFill();
            A.SchemeColor schemeColor9 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill3.Append(schemeColor9);
            A.PresetDash presetDash2 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };
            A.Miter miter2 = new A.Miter() { Limit = 800000 };

            outline2.Append(solidFill3);
            outline2.Append(presetDash2);
            outline2.Append(miter2);

            A.Outline outline3 = new A.Outline() { Width = 19050, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill4 = new A.SolidFill();
            A.SchemeColor schemeColor10 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill4.Append(schemeColor10);
            A.PresetDash presetDash3 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };
            A.Miter miter3 = new A.Miter() { Limit = 800000 };

            outline3.Append(solidFill4);
            outline3.Append(presetDash3);
            outline3.Append(miter3);

            lineStyleList1.Append(outline1);
            lineStyleList1.Append(outline2);
            lineStyleList1.Append(outline3);

            A.EffectStyleList effectStyleList1 = new A.EffectStyleList();

            A.EffectStyle effectStyle1 = new A.EffectStyle();
            A.EffectList effectList1 = new A.EffectList();

            effectStyle1.Append(effectList1);

            A.EffectStyle effectStyle2 = new A.EffectStyle();
            A.EffectList effectList2 = new A.EffectList();

            effectStyle2.Append(effectList2);

            A.EffectStyle effectStyle3 = new A.EffectStyle();

            A.EffectList effectList3 = new A.EffectList();

            A.OuterShadow outerShadow1 = new A.OuterShadow() { BlurRadius = 57150L, Distance = 19050L, Direction = 5400000, Alignment = A.RectangleAlignmentValues.Center, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex11 = new A.RgbColorModelHex() { Val = "000000" };
            A.Alpha alpha1 = new A.Alpha() { Val = 63000 };

            rgbColorModelHex11.Append(alpha1);

            outerShadow1.Append(rgbColorModelHex11);

            effectList3.Append(outerShadow1);

            effectStyle3.Append(effectList3);

            effectStyleList1.Append(effectStyle1);
            effectStyleList1.Append(effectStyle2);
            effectStyleList1.Append(effectStyle3);

            A.BackgroundFillStyleList backgroundFillStyleList1 = new A.BackgroundFillStyleList();

            A.SolidFill solidFill5 = new A.SolidFill();
            A.SchemeColor schemeColor11 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill5.Append(schemeColor11);

            A.SolidFill solidFill6 = new A.SolidFill();

            A.SchemeColor schemeColor12 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint5 = new A.Tint() { Val = 95000 };
            A.SaturationModulation saturationModulation7 = new A.SaturationModulation() { Val = 170000 };

            schemeColor12.Append(tint5);
            schemeColor12.Append(saturationModulation7);

            solidFill6.Append(schemeColor12);

            A.GradientFill gradientFill3 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList3 = new A.GradientStopList();

            A.GradientStop gradientStop7 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor13 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint6 = new A.Tint() { Val = 93000 };
            A.SaturationModulation saturationModulation8 = new A.SaturationModulation() { Val = 150000 };
            A.Shade shade3 = new A.Shade() { Val = 98000 };
            A.LuminanceModulation luminanceModulation7 = new A.LuminanceModulation() { Val = 102000 };

            schemeColor13.Append(tint6);
            schemeColor13.Append(saturationModulation8);
            schemeColor13.Append(shade3);
            schemeColor13.Append(luminanceModulation7);

            gradientStop7.Append(schemeColor13);

            A.GradientStop gradientStop8 = new A.GradientStop() { Position = 50000 };

            A.SchemeColor schemeColor14 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint7 = new A.Tint() { Val = 98000 };
            A.SaturationModulation saturationModulation9 = new A.SaturationModulation() { Val = 130000 };
            A.Shade shade4 = new A.Shade() { Val = 90000 };
            A.LuminanceModulation luminanceModulation8 = new A.LuminanceModulation() { Val = 103000 };

            schemeColor14.Append(tint7);
            schemeColor14.Append(saturationModulation9);
            schemeColor14.Append(shade4);
            schemeColor14.Append(luminanceModulation8);

            gradientStop8.Append(schemeColor14);

            A.GradientStop gradientStop9 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor15 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade5 = new A.Shade() { Val = 63000 };
            A.SaturationModulation saturationModulation10 = new A.SaturationModulation() { Val = 120000 };

            schemeColor15.Append(shade5);
            schemeColor15.Append(saturationModulation10);

            gradientStop9.Append(schemeColor15);

            gradientStopList3.Append(gradientStop7);
            gradientStopList3.Append(gradientStop8);
            gradientStopList3.Append(gradientStop9);
            A.LinearGradientFill linearGradientFill3 = new A.LinearGradientFill() { Angle = 5400000, Scaled = false };

            gradientFill3.Append(gradientStopList3);
            gradientFill3.Append(linearGradientFill3);

            backgroundFillStyleList1.Append(solidFill5);
            backgroundFillStyleList1.Append(solidFill6);
            backgroundFillStyleList1.Append(gradientFill3);

            formatScheme1.Append(fillStyleList1);
            formatScheme1.Append(lineStyleList1);
            formatScheme1.Append(effectStyleList1);
            formatScheme1.Append(backgroundFillStyleList1);

            themeElements1.Append(colorScheme1);
            themeElements1.Append(fontScheme21);
            themeElements1.Append(formatScheme1);
            A.ObjectDefaults objectDefaults1 = new A.ObjectDefaults();

            theme1.Append(themeElements1);
            theme1.Append(objectDefaults1);

            themePart1.Theme = theme1;
        }

        // Generates content of worksheetPart1.
        private void GenerateWorksheetPart1Content(WorksheetPart worksheetPart1)
        {
            Worksheet worksheet1 = new Worksheet();
            worksheet1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            worksheet1.AddNamespaceDeclaration("xdr", "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing");
            worksheet1.AddNamespaceDeclaration("x14", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main");
            worksheet1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            worksheet1.AddNamespaceDeclaration("etc", "http://www.wps.cn/officeDocument/2017/etCustomData");
            SheetProperties sheetProperties1 = new SheetProperties();
            SheetDimension sheetDimension1 = new SheetDimension() { Reference = "A1:C5" };

            SheetViews sheetViews1 = new SheetViews();

            SheetView sheetView1 = new SheetView() { TabSelected = true, WorkbookViewId = (UInt32Value)0U };
            Selection selection1 = new Selection() { ActiveCell = "D5", SequenceOfReferences = new ListValue<StringValue>() { InnerText = "D5" } };

            sheetView1.Append(selection1);

            sheetViews1.Append(sheetView1);
            SheetFormatProperties sheetFormatProperties1 = new SheetFormatProperties() { DefaultColumnWidth = 9.14285714285714D, DefaultRowHeight = 15D, OutlineLevelRow = 4, OutlineLevelColumn = 2 };

            Columns columns1 = new Columns();
            Column column1 = new Column() { Min = (UInt32Value)1U, Max = (UInt32Value)1U, Width = 9.28571428571429D, CustomWidth = true };
            Column column2 = new Column() { Min = (UInt32Value)2U, Max = (UInt32Value)2U, Width = 6.14285714285714D, CustomWidth = true };
            Column column3 = new Column() { Min = (UInt32Value)3U, Max = (UInt32Value)3U, Width = 18.7142857142857D, CustomWidth = true };

            columns1.Append(column1);
            columns1.Append(column2);
            columns1.Append(column3);

            SheetData sheetData1 = new SheetData();

            Row row1 = new Row() { RowIndex = (UInt32Value)1U, Spans = new ListValue<StringValue>() { InnerText = "1:1" } };
            Cell cell1 = new Cell() { CellReference = "A1", StyleIndex = (UInt32Value)1U };

            row1.Append(cell1);

            Row row2 = new Row() { RowIndex = (UInt32Value)3U, Spans = new ListValue<StringValue>() { InnerText = "1:3" } };

            Cell cell2 = new Cell() { CellReference = "A3", StyleIndex = (UInt32Value)2U, DataType = CellValues.SharedString };
            CellValue cellValue1 = new CellValue();
            cellValue1.Text = "0";

            cell2.Append(cellValue1);

            Cell cell3 = new Cell() { CellReference = "B3", StyleIndex = (UInt32Value)2U, DataType = CellValues.SharedString };
            CellValue cellValue2 = new CellValue();
            cellValue2.Text = "1";

            cell3.Append(cellValue2);

            Cell cell4 = new Cell() { CellReference = "C3", StyleIndex = (UInt32Value)2U, DataType = CellValues.SharedString };
            CellValue cellValue3 = new CellValue();
            cellValue3.Text = "2";

            cell4.Append(cellValue3);

            row2.Append(cell2);
            row2.Append(cell3);
            row2.Append(cell4);

            Row row3 = new Row() { RowIndex = (UInt32Value)4U, Spans = new ListValue<StringValue>() { InnerText = "1:3" } };

            Cell cell5 = new Cell() { CellReference = "A4", StyleIndex = (UInt32Value)3U };
            CellValue cellValue4 = new CellValue();
            cellValue4.Text = "30594.6358796296";

            cell5.Append(cellValue4);

            Cell cell6 = new Cell() { CellReference = "B4", StyleIndex = (UInt32Value)4U };
            CellValue cellValue5 = new CellValue();
            cellValue5.Text = "30594.6358796296";

            cell6.Append(cellValue5);

            Cell cell7 = new Cell() { CellReference = "C4", StyleIndex = (UInt32Value)5U };
            CellValue cellValue6 = new CellValue();
            cellValue6.Text = "3.3";

            cell7.Append(cellValue6);

            row3.Append(cell5);
            row3.Append(cell6);
            row3.Append(cell7);

            Row row4 = new Row() { RowIndex = (UInt32Value)5U, Spans = new ListValue<StringValue>() { InnerText = "1:3" } };

            Cell cell8 = new Cell() { CellReference = "A5", StyleIndex = (UInt32Value)3U };
            CellValue cellValue7 = new CellValue();
            cellValue7.Text = "30594.6358796296";

            cell8.Append(cellValue7);

            Cell cell9 = new Cell() { CellReference = "B5", StyleIndex = (UInt32Value)4U };
            CellValue cellValue8 = new CellValue();
            cellValue8.Text = "30594.6358796296";

            cell9.Append(cellValue8);

            Cell cell10 = new Cell() { CellReference = "C5", StyleIndex = (UInt32Value)5U };
            CellValue cellValue9 = new CellValue();
            cellValue9.Text = "3.3";

            cell10.Append(cellValue9);

            row4.Append(cell8);
            row4.Append(cell9);
            row4.Append(cell10);

            sheetData1.Append(row1);
            sheetData1.Append(row2);
            sheetData1.Append(row3);
            sheetData1.Append(row4);
            PageMargins pageMargins1 = new PageMargins() { Left = 0.75D, Right = 0.75D, Top = 1D, Bottom = 1D, Header = 0.5D, Footer = 0.5D };
            HeaderFooter headerFooter1 = new HeaderFooter();

            worksheet1.Append(sheetProperties1);
            worksheet1.Append(sheetDimension1);
            worksheet1.Append(sheetViews1);
            worksheet1.Append(sheetFormatProperties1);
            worksheet1.Append(columns1);
            worksheet1.Append(sheetData1);
            worksheet1.Append(pageMargins1);
            worksheet1.Append(headerFooter1);

            worksheetPart1.Worksheet = worksheet1;
        }

        // Generates content of extendedFilePropertiesPart1.
        private void GenerateExtendedFilePropertiesPart1Content(ExtendedFilePropertiesPart extendedFilePropertiesPart1)
        {
            Ap.Properties properties1 = new Ap.Properties();
            properties1.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
            Ap.Application application1 = new Ap.Application();
            application1.Text = "WPS Spreadsheets";

            Ap.HeadingPairs headingPairs1 = new Ap.HeadingPairs();

            Vt.VTVector vTVector1 = new Vt.VTVector() { BaseType = Vt.VectorBaseValues.Variant, Size = (UInt32Value)2U };

            Vt.Variant variant1 = new Vt.Variant();
            Vt.VTLPSTR vTLPSTR1 = new Vt.VTLPSTR();
            vTLPSTR1.Text = "工作表";

            variant1.Append(vTLPSTR1);

            Vt.Variant variant2 = new Vt.Variant();
            Vt.VTInt32 vTInt321 = new Vt.VTInt32();
            vTInt321.Text = "1";

            variant2.Append(vTInt321);

            vTVector1.Append(variant1);
            vTVector1.Append(variant2);

            headingPairs1.Append(vTVector1);

            Ap.TitlesOfParts titlesOfParts1 = new Ap.TitlesOfParts();

            Vt.VTVector vTVector2 = new Vt.VTVector() { BaseType = Vt.VectorBaseValues.Lpstr, Size = (UInt32Value)1U };
            Vt.VTLPSTR vTLPSTR2 = new Vt.VTLPSTR();
            vTLPSTR2.Text = "Sheet1";

            vTVector2.Append(vTLPSTR2);

            titlesOfParts1.Append(vTVector2);

            properties1.Append(application1);
            properties1.Append(headingPairs1);
            properties1.Append(titlesOfParts1);

            extendedFilePropertiesPart1.Properties = properties1;
        }

        // Generates content of customFilePropertiesPart1.
        private void GenerateCustomFilePropertiesPart1Content(CustomFilePropertiesPart customFilePropertiesPart1)
        {
            Op.Properties properties2 = new Op.Properties();
            properties2.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");

            Op.CustomDocumentProperty customDocumentProperty1 = new Op.CustomDocumentProperty() { FormatId = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}", PropertyId = 2, Name = "KSOProductBuildVer" };
            Vt.VTLPWSTR vTLPWSTR1 = new Vt.VTLPWSTR();
            vTLPWSTR1.Text = "1033-11.2.0.8970";

            customDocumentProperty1.Append(vTLPWSTR1);

            properties2.Append(customDocumentProperty1);

            customFilePropertiesPart1.Properties = properties2;
        }

        private void SetPackageProperties(OpenXmlPackage document)
        {
            document.PackageProperties.Creator = "Login";
            document.PackageProperties.Created = System.Xml.XmlConvert.ToDateTime("2019-10-02T07:56:00Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.Modified = System.Xml.XmlConvert.ToDateTime("2019-10-02T08:06:15Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.LastModifiedBy = "Login";
        }


    }
}
