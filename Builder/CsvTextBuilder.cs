using System.Text;

namespace Builder;

public class CsvTextBuilder(char delimiter = ',') : ICsvTextBuilder
{
    private readonly StringBuilder _sb = new();

    public ICsvTextBuilder AddHeader(params string[] header)
    {
        _sb.AppendLine(string.Join(delimiter, header) + Environment.NewLine);
        return this;
    }

    public ICsvTextBuilder AddRow(params object[] row)
    {
        _sb.AppendLine(string.Join(delimiter, row));
        return this;
    }

    public string CreateText()
    {
        return _sb.ToString();
    }
}
