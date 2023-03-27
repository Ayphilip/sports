public class Chromosome
{
    public double[] Genes { get; set; }
    public double Fitness { get; set; }

    public Chromosome(int geneLength)
    {
        Genes = new double[geneLength];
    }
}
