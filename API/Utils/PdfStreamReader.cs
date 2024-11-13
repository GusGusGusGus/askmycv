using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using System.Text;
using System.Text.RegularExpressions;

public class PdfStreamReader
{
    public static string ReadPdfText(Stream pdfStream)
    {
        StringBuilder text = new StringBuilder();
        
        try
        {
            using (var document = PdfDocument.Open(pdfStream))
            {
                foreach (var page in document.GetPages())
                {
                    text.AppendLine(page.Text);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error reading PDF: {ex.Message}", ex);
        }
        
        return text.ToString();
    }
    
    // Overload to read specific pages
    public static string ReadPdfText(Stream pdfStream, int startPage, int endPage)
    {
        StringBuilder text = new StringBuilder();
        
        try
        {
            using (var document = PdfDocument.Open(pdfStream))
            {
                int maxPages = document.NumberOfPages;
                startPage = Math.Max(1, startPage);
                endPage = Math.Min(maxPages, endPage);
                
                for (int i = startPage; i <= endPage; i++)
                {
                    var page = document.GetPage(i);
                    text.AppendLine(page.Text);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error reading PDF: {ex.Message}", ex);
        }
        
        return text.ToString();
    }

    // Additional method to get PDF metadata
    public static Dictionary<string, string> GetMetadata(Stream pdfStream)
    {
        try
        {
            using (var document = PdfDocument.Open(pdfStream))
            {
                return new Dictionary<string, string>
                {
                    { "Title", document.Information.Title },
                    { "Author", document.Information.Author },
                    { "Subject", document.Information.Subject },
                    { "Keywords", document.Information.Keywords },
                    { "Creator", document.Information.Creator },
                    { "Producer", document.Information.Producer },
                    { "CreationDate", document.Information.CreationDate?.ToString() },
                    { "ModificationDate", document.Information.ModifiedDate?.ToString() }
                };
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error reading PDF metadata: {ex.Message}", ex);
        }
    }


     public class TextExtractionResult
    {
        public int PageNumber { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public string Text { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public static List<TextExtractionResult> ExtractTextWithPosition(Stream pdfStream, string searchText = null)
    {
        var results = new List<TextExtractionResult>();
        
        try
        {
            using (var document = PdfDocument.Open(pdfStream))
            {
                foreach (var page in document.GetPages())
                {
                    foreach (var word in page.GetWords())
                    {
                        // If searchText is provided, only include matching words
                        if (string.IsNullOrEmpty(searchText) || 
                            word.Text.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                        {
                            results.Add(new TextExtractionResult
                            {
                                PageNumber = page.Number,
                                X = word.BoundingBox.Left,
                                Y = word.BoundingBox.Bottom,
                                Text = word.Text,
                                Width = word.BoundingBox.Width,
                                Height = word.BoundingBox.Height
                            });
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error extracting text with position: {ex.Message}", ex);
        }
        
        return results;
    }

    public static List<string> ExtractTextByPattern(Stream pdfStream, string pattern)
    {
        var matches = new List<string>();
        var regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        
        try
        {
            using (var document = PdfDocument.Open(pdfStream))
            {
                foreach (var page in document.GetPages())
                {
                    var pageText = page.Text;
                    var pageMatches = regex.Matches(pageText);
                    
                    foreach (Match match in pageMatches)
                    {
                        matches.Add(match.Value);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error extracting text by pattern: {ex.Message}", ex);
        }
        
        return matches;
    }

    public static Dictionary<int, List<string>> ExtractTableData(Stream pdfStream)
    {
        var tableData = new Dictionary<int, List<string>>();
        
        try
        {
            using (var document = PdfDocument.Open(pdfStream))
            {
                foreach (var page in document.GetPages())
                {
                    var words = page.GetWords().OrderBy(w => w.BoundingBox.Bottom)
                                              .ThenBy(w => w.BoundingBox.Left)
                                              .ToList();
                    
                    // Group words by their Y position (with small tolerance for alignment)
                    const double tolerance = 5;
                    var rows = words.GroupBy(w => Math.Round(w.BoundingBox.Bottom / tolerance) * tolerance)
                                  .OrderByDescending(g => g.Key);
                    
                    var rowData = new List<string>();
                    foreach (var row in rows)
                    {
                        rowData.Add(string.Join(" ", row.Select(w => w.Text)));
                    }
                    
                    tableData[page.Number] = rowData;
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error extracting table data: {ex.Message}", ex);
        }
        
        return tableData;
    }
}