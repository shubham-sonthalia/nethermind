//  Copyright (c) 2018 Demerzel Solutions Limited
//  This file is part of the Nethermind library.
// 
//  The Nethermind library is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  The Nethermind library is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU Lesser General Public License for more details.
// 
//  You should have received a copy of the GNU Lesser General Public License
//  along with the Nethermind. If not, see <http://www.gnu.org/licenses/>.

using System.Threading.Tasks;
using Nethermind.DataMarketplace.Core.Services.Models;
using Nethermind.Int256;

namespace Nethermind.DataMarketplace.Core.Services
{
    public interface IGasPriceService
    {
        GasPriceTypes? Types { get; }
        Task<UInt256> GetCurrentAsync();
        Task<UInt256> GetCurrentRefundAsync();
        Task<UInt256> GetCurrentPaymentClaimAsync();
        Task SetAsync(string gasPriceOrType);
        Task SetRefundAsync(UInt256 gasPrice);
        Task SetPaymentClaimAsync(UInt256 gasPrice);
        Task UpdateAsync();
    }
}
