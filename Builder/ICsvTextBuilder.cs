namespace Builder;

public interface ICsvTextBuilder
{
    ICsvTextBuilder AddHeader(params string[] header);

    ICsvTextBuilder AddRow(params object[] row);

    string CreateText();
}
