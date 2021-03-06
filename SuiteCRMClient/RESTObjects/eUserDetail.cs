﻿/**
 * Outlook integration for SuiteCRM.
 * @package Outlook integration for SuiteCRM
 * @copyright SalesAgility Ltd http://www.salesagility.com
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU LESSER GENERAL PUBLIC LICENCE as published by
 * the Free Software Foundation; either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU LESSER GENERAL PUBLIC LICENCE
 * along with this program; if not, see http://www.gnu.org/licenses
 * or write to the Free Software Foundation,Inc., 51 Franklin Street,
 * Fifth Floor, Boston, MA 02110-1301  USA
 *
 * @author SalesAgility <info@salesagility.com>
 */
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiteCRMClient.RESTObjects
{
   public class eUserDetail
    {
       [JsonProperty("department")]
       public string department{ get; set; }
       [JsonProperty("email_address")]
       public string email_address{ get; set; }
       [JsonProperty("first_name")]
       public string first_name{ get; set; }
       [JsonProperty("id")]
       public string id{ get; set; }
        [JsonProperty("last_name")]
        public string last_name{ get; set; }
        [JsonProperty("title")]
        public string title{ get; set; }
        [JsonProperty("user_name")]
        public string user_name{ get; set; }
    }
}
