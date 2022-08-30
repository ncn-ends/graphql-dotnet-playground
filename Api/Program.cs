using GraphQL;
using GraphQL.Types;
using GraphQL.SystemTextJson;

var schema = Schema.For(@"
    type Query {
        hello: String     
    }
");

var json = await schema.ExecuteAsync(_ =>
{
    _.Query = "{ hello }";
    _.Root = new {Hello = "Hello World!"};
});

Console.WriteLine(json);