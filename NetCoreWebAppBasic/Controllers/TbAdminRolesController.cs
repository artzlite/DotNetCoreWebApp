using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetCoreWebAppBasic.DAL;

namespace NetCoreWebAppBasic.Controllers
{
    public class TbAdminRolesController : Controller
    {
        private readonly LNAContext _context;

        public TbAdminRolesController(LNAContext context)
        {
            _context = context;
        }

        // GET: TbAdminRoles
        public async Task<IActionResult> Index()
        {
            return View(await _context.TbAdminRole.ToListAsync());
        }

        // GET: TbAdminRoles/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbAdminRole = await _context.TbAdminRole
                .FirstOrDefaultAsync(m => m.Oid == id);
            if (tbAdminRole == null)
            {
                return NotFound();
            }

            return View(tbAdminRole);
        }

        // GET: TbAdminRoles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TbAdminRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Oid,Code,RoleNameThai,RoleNameEng,CreatedBy,CreatedOn,UpdatedBy,UpdatedOn,DeleteFlag")] TbAdminRole tbAdminRole)
        {
            if (ModelState.IsValid)
            {
                tbAdminRole.Oid = Guid.NewGuid();
                _context.Add(tbAdminRole);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tbAdminRole);
        }

        // GET: TbAdminRoles/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbAdminRole = await _context.TbAdminRole.FindAsync(id);
            if (tbAdminRole == null)
            {
                return NotFound();
            }
            return View(tbAdminRole);
        }

        // POST: TbAdminRoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Oid,Code,RoleNameThai,RoleNameEng,CreatedBy,CreatedOn,UpdatedBy,UpdatedOn,DeleteFlag")] TbAdminRole tbAdminRole)
        {
            if (id != tbAdminRole.Oid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tbAdminRole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbAdminRoleExists(tbAdminRole.Oid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tbAdminRole);
        }

        // GET: TbAdminRoles/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbAdminRole = await _context.TbAdminRole
                .FirstOrDefaultAsync(m => m.Oid == id);
            if (tbAdminRole == null)
            {
                return NotFound();
            }

            return View(tbAdminRole);
        }

        // POST: TbAdminRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var tbAdminRole = await _context.TbAdminRole.FindAsync(id);
            _context.TbAdminRole.Remove(tbAdminRole);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbAdminRoleExists(Guid id)
        {
            return _context.TbAdminRole.Any(e => e.Oid == id);
        }
    }
}
