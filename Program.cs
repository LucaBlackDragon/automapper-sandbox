using AutoMapper;
		
var config = new MapperConfiguration(
  cfg => cfg.CreateMap<Source, Target>()
          //.ConstructUsing(s => new Target(s.Prop))
);
var mapper = config.CreateMapper();

var source = new Source { Prop = "VALUE" };
var target = mapper.Map<Target>(source);

Console.WriteLine("target.Prop: {0}", target.Prop);

public class Target
{
  private static readonly string PREFIX = "TEST_";

  public Target(string prop)
  {
    this.Prop = PREFIX + prop;
  }

  public string Prop { get; private set; }
}

public class Source
{
  public string Prop { get; set; }
}