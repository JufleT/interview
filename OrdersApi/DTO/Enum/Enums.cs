using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersApi.DTO.Enum
{
	public enum EOrderStatus : byte
	{
		Processed = 1,
		Unprocessed = 2,
		Cancelled = 3
	}
}
