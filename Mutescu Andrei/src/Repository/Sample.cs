using System;


public class Sample
{
	public Sample(Guid Id,string DnaSequence,DateTime AnalysisTime)
	{
		Id = id;
		DnaSequence = Dnasequence;
		AnalysisTime = Analysistime;
	}
	public Guid Id { get; private set; }

	public string DnaSequence { get; private set; }

	public DateTime AnalysisTime { get; private set; }

}
