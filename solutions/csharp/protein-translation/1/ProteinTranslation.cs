public static class ProteinTranslation
{
    const string METHIONINE = "Methionine";
    const string PHENYALALANINE = "Phenylalanine";
    const string LEUCINE = "Leucine";
    const string SERINE = "Serine";
    const string TYROSINE = "Tyrosine";
    const string CYSTEINE = "Cysteine";
    const string TRYPTOPHAN = "Tryptophan";

    public static string[] Proteins(string strand)
    {
        List<string> proteins = [];

        for (int i = 0; i + 3 <= strand.Length; i += 3)
        {
            var codon = strand.Substring(i, 3);
            if (codon == "AUG")
            {
                proteins.Add(METHIONINE);
            }
            else if (codon is "UUU" or "UUC")
            {
                proteins.Add(PHENYALALANINE);
            }
            else if (codon is "UUA" or "UUG")
            {
                proteins.Add(LEUCINE);
            }
            else if (codon is "UCU" or "UCC" or "UCA" or "UCG")
            {
                proteins.Add(SERINE);
            }
            else if (codon is "UAU" or "UAC")
            {
                proteins.Add(TYROSINE);
            }
            else if (codon is "UGU" or "UGC")
            {
                proteins.Add(CYSTEINE);
            }
            else if (codon == "UGG")
            {
                proteins.Add(TRYPTOPHAN);
            }
            else if (codon is "UAA" or "UAG" or "UGA")
            {
                break;
            }
        }

        return [.. proteins];
    }
}