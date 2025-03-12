using System.IdentityModel.Tokens.Jwt;
using System;
using System.Text;
using HospitalManagement.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Models
{
        public class AuthServices : IAuthServices
        {
            private readonly HospitalDbContext _context;
            private readonly JwtSettings _jwtSettings;

            public AuthServices(HospitalDbContext context, IOptions<JwtSettings> jwtSettings)
            {
                _context = context;
                _jwtSettings = jwtSettings.Value;
            }
            public async Task<string> Authenticate(string username, string password)
            {
                var doctor = await _context.Doctors.SingleOrDefaultAsync(u => u.DoctorUserName == username);
                if (doctor == null || doctor.DoctorPassword != password) // Use hashed passwords in production
                {
                    return null;
                }

                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: _jwtSettings.Issuer,
                    audience: _jwtSettings.Audience,
                    expires: DateTime.Now.AddMinutes(_jwtSettings.ExpirationMinutes),
                    signingCredentials: credentials
                );

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
        }
    }

