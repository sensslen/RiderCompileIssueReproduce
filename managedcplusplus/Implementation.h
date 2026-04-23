#pragma once

#include "Interface.h"

namespace ManagedCpp
{
	public ref class Implementation : public IInterface
	{
	public:
		virtual int Add(int a, int b);
	};
}