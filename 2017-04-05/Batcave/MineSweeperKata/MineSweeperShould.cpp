#include "stdafx.h"
#include "CppUnitTest.h"

#include <algorithm>
#include <vector>

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

using namespace std;

namespace MineSweeperKata
{
	class MineSweeper
	{
	public:
		vector<vector<int>> Annotate(const vector<vector<bool>>& mineField) noexcept
		{
			Initialize(mineField);

			for (int i = 0; i < m_height; ++i)
			{
				for (int j = 0; j < m_width; ++j)
				{
					m_mineField[i][j] = Visit(mineField, j, i);
				}
			}

			return m_mineField;
		}

		void Initialize(const vector<vector<bool>>& mineField) noexcept
		{
			m_height = mineField.size();
			m_width = mineField[0].size();

			m_mineField.resize(m_height);
			for (int i = 0; i < m_height; ++i)
			{
				m_mineField[i].resize(m_width);
			}
		}

		int Visit(const vector<vector<bool>>& mineField, int x, int y) const noexcept
		{
			int result = 0;

			if (mineField[y][x])
			{
				return bombSpecialValue;
			}


			for (int i = max(0, x - 1); i <= min(m_width - 1, x + 1); ++i)
			{
				for (int j = max(0, y - 1); j <= min(m_height - 1, y + 1); ++j)
				{
					if (i == x && j == y) continue;
					if (mineField[j][i]) ++result;
				}
			}

			return result;
		}

		string OutputSolution() const noexcept
		{
			stringstream output;
			for (int i = 0; i < m_height; ++i)
			{
				for (int j = 0; j < m_width; ++j)
				{
					int cellValue = m_mineField[i][j];
					if (cellValue == bombSpecialValue)
					{
						output << '*';
					}
					else
					{
						output << cellValue;
					}
				}

				if (i != m_height - 1)
				{
					output << endl;
				}
			}

			return output.str();
		}

	private:
		int m_width;
		int m_height;
		vector<vector<int>> m_mineField;

		static const int bombSpecialValue = 42;
	};

	TEST_CLASS(MineSweeperShould)
	{
	public:

		TEST_METHOD(InitializeWithZero)
		{
			vector<vector<bool>> mineField
			{
				{ true }
			};

			MineSweeper sweeper;
			sweeper.Initialize(mineField);

			Assert::AreEqual(static_cast<string>("0"), sweeper.OutputSolution());
		}

		void VisitCellTestCase(int x, int y, int expected)
		{
			vector<vector<bool>> mineField
			{
				{ true, false, false, false },
				{ false, false, false, false },
				{ false, true, false, false },
				{ false, false, false, false }
			};

			MineSweeper sweeper;
			sweeper.Initialize(mineField);
			auto actual = sweeper.Visit(mineField, x, y);
			Assert::AreEqual(expected, actual);
		}

		TEST_METHOD(CorrectlyVisitOneCellWithBomb)
		{
			VisitCellTestCase(0, 0, 42);
		}

		TEST_METHOD(CorrectlyVisitOneCellCorner)
		{
			VisitCellTestCase(0, 3, 1);
		}

		TEST_METHOD(CorrectlyVisitOneWithMultipleBombs)
		{
			VisitCellTestCase(1, 1, 2);
		}

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

			Assert::IsTrue(expectedAnnotatedMineField == annotatedMineField);
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

			Assert::IsTrue(expectedAnnotatedMineField == annotatedMineField);
		}

		TEST_METHOD(CorrectlyOutputSolution)
		{
			vector<vector<bool>> mineField
			{
				{ true, true, false, false, false },
				{ false, false, false, false, false },
				{ false, true, false, false, false }
			};

			MineSweeper sweeper;
			sweeper.Annotate(mineField);
			auto output = sweeper.OutputSolution();

			vector<vector<int>> expectedAnnotatedMineField
			{
				{ 42, 42, 1, 0, 0 },
				{ 3, 3, 2, 0, 0 },
				{ 1, 42, 1, 0, 0 }
			};

			Assert::AreEqual(
				static_cast<string>("**100\n33200\n1*100"), 
				output);
		}
	};
}