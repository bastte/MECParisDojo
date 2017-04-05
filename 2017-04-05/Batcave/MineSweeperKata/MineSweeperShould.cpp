#include "stdafx.h"
#include "CppUnitTest.h"

#include <vector>

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

using namespace std;

namespace MineSweeperKata
{
	TEST_CLASS(MineSweeperShould)
	{
	public:

		TEST_METHOD(PassFirstAcceptanceTest)
		{
			vector<vector<bool>> mineField
			{
				{ true, false, false, false },
				{ false, false, false, false },
				{ false, true, false, false },
				{ false, false, false, false }
			};

			MineSweeper sweeper;
			vector<vector<int>> annotatedMineField = sweeper.Annotate(mineField);

			vector<vector<int>> expectedAnnotatedMineField
			{
				{42, 1, 0, 0},
				{2, 2, 1, 0},
				{1, 42, 1, 0},
				{1, 1, 1, 0}
			};

			Assert::AreEqual(expectedAnnotatedMineField, annotatedMineField);
		}

		TEST_METHOD(PassSecondAcceptanceTest)
		{
			vector<vector<bool>> mineField
			{
				{ true, true, false, false, false },
				{ false, false, false, false, false },
				{ false, true, false, false, false }
			};

			MineSweeper sweeper;
			vector<vector<int>> annotatedMineField = sweeper.Annotate(mineField);

			vector<vector<int>> expectedAnnotatedMineField
			{
				{ 42, 42, 1, 0, 0 },
				{ 3, 3, 2, 0, 0 },
				{ 1, 42, 1, 0, 0 }
			};

			Assert::AreEqual(expectedAnnotatedMineField, annotatedMineField);
		}

	};
}