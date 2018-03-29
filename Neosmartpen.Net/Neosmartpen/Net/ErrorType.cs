﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neosmartpen.Net
{
	public enum ErrorType
	{
		MissingPenUp = 1,
		MissingPenDown = 2,
		InvalidTime = 3,
		MissingPenDownPenMove = 4,
		ImageProcessingError = 5,
		InvalidEventCount = 6,
		MissingPageChange = 7
	}
}
