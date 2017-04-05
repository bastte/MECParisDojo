#include "stdafx.h"
#include "CppUnitTest.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace MineSweeperKata
{		
	TEST_CLASS(MineSweeperShould)
	{
	public:
		
		TEST_METHOD(FailSinceWeHaventStartedYet)
		{
			Assert::Fail();
		}

	};
}