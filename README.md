# My NSubstitute Experience

## Preface

I want to test Runner class.

https://github.com/sengokyu/SubstituteConcreteClassExperience/blob/master/ClassLibrary1/Runner.cs

Runner class depend on Class1 class.
But the method of Class1 are not virual, then can not mocks it's behaviour.

So I create an extend class of Class1 (named Class1Wrapper),

https://github.com/sengokyu/SubstituteConcreteClassExperience/blob/master/ClassLibrary1.Tests/Class1Wrapper.cs

And passes Mocked Class1Wrapper to my test target Runner class.

https://github.com/sengokyu/SubstituteConcreteClassExperience/blob/master/ClassLibrary1.Tests/RunnerTest.cs

## Problem

Passed argument to Runner class does not behave as Mocked instance.
It seems behave as original base class.


## Cause

Perhaps, proxied class casted to the base class?

