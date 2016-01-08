/*
 * 描述:
 *  
 * 修订历史: 
 * 日期                    修改人              Email                   内容
 * 2015-12-02                                         创建 
 *  
 */

using Project.Common.Helper;
using Project.DAL;
using Project.DAL.Database;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Project.BLL
{
    public class tm_pm_projectBLL
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_tm_pm_project model)
        {
            if (model == null)
                return string.Empty;

            using (tm_pm_projectDAL dal = new tm_pm_projectDAL())
            {
                tm_pm_project entity = ModelToEntity(model);
                entity.PROJECTID = string.IsNullOrEmpty(model.PROJECTID) ? Guid.NewGuid().ToString("N") : model.PROJECTID;

                return dal.Add(entity);
            }
        }

        /// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_tm_pm_project Get(Expression<Func<tm_pm_project, bool>> predicate = null)
        {
            using (tm_pm_projectDAL dal = new tm_pm_projectDAL())
            {
                tm_pm_project entity = dal.Get(predicate);
                return EntityToModel(entity);
            }
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_tm_pm_project> Get()
        {
            using (tm_pm_projectDAL dal = new tm_pm_projectDAL())
            {
                List<tm_pm_project> entitys = dal.Get().ToList();
                List<V_tm_pm_project> list = new List<V_tm_pm_project>();
                foreach (tm_pm_project item in entitys)
                {
                    list.Add(EntityToModel(item));
                }
                return list;
            }
        }

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public IEnumerable<V_tm_pm_project> GetList(PageInfo page)
        {
            using (tm_pm_projectDAL dal = new tm_pm_projectDAL())
            {
                var list = dal.Get();

                return list.Paging(ref page).Select(EntityToModel).ToList();
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_tm_pm_project model)
        {
            if (model == null) return false;
            using (tm_pm_projectDAL dal = new tm_pm_projectDAL())
            {
                tm_pm_project entitys = ModelToEntity(model);

                return dal.Edit(entitys);
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return false;
            using (tm_pm_projectDAL dal = new tm_pm_projectDAL())
            {
                return dal.Delete(id);
            }
        }

        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private tm_pm_project ModelToEntity(V_tm_pm_project model)
        {
            if (model != null)
            {
                tm_pm_project entity = new tm_pm_project()
                {
                    PROJECTID = model.PROJECTID,
                    OWENRID = model.OWENRID,
                    OWNERPOSTID = model.OWNERPOSTID,
                    OWNERDEPARTMENTID = model.OWNERDEPARTMENTID,
                    OWNERCOMPANYID = model.OWNERCOMPANYID,
                    CREATETIME = model.CREATETIME,
                    CREATEUSER = model.CREATEUSER,
                    EDITTIME = model.EDITTIME,
                    EDITUSER = model.EDITUSER,
                    PMANAGER = model.PMANAGER,
                    ISCOMFIRM = model.ISCOMFIRM,
                    ORDERNUMBER = model.ORDERNUMBER,
                    REALFINISHDATE = model.REALFINISHDATE,
                    RESULTSCORE = model.RESULTSCORE,
                    SUGGESTIONS = model.SUGGESTIONS,
                    BUDGET = model.BUDGET,
                    REALCOST = model.REALCOST,
                    PROJECTNAME = model.PROJECTNAME,
                    FATHERPROJECTID = model.FATHERPROJECTID,
                    COSTTIME = model.COSTTIME,
                    STARTDATE = model.STARTDATE,
                    ENDDATE = model.ENDDATE,
                    PROGRESS = model.PROGRESS,
                    PROJECTREMARK = model.PROJECTREMARK,
                };

                return entity;
            }
            return null;
        }

        /// <summary>
        /// Entity转Model
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private V_tm_pm_project EntityToModel(tm_pm_project entity)
        {
            if (entity != null)
            {
                V_tm_pm_project model = new V_tm_pm_project()
                {
                    PROJECTID = entity.PROJECTID,
                    OWENRID = entity.OWENRID,
                    OWNERPOSTID = entity.OWNERPOSTID,
                    OWNERDEPARTMENTID = entity.OWNERDEPARTMENTID,
                    OWNERCOMPANYID = entity.OWNERCOMPANYID,
                    CREATETIME = entity.CREATETIME,
                    CREATEUSER = entity.CREATEUSER,
                    EDITTIME = entity.EDITTIME,
                    EDITUSER = entity.EDITUSER,
                    PMANAGER = entity.PMANAGER,
                    ISCOMFIRM = entity.ISCOMFIRM,
                    ORDERNUMBER = entity.ORDERNUMBER,
                    REALFINISHDATE = entity.REALFINISHDATE,
                    RESULTSCORE = entity.RESULTSCORE,
                    SUGGESTIONS = entity.SUGGESTIONS,
                    BUDGET = entity.BUDGET,
                    REALCOST = entity.REALCOST,
                    PROJECTNAME = entity.PROJECTNAME,
                    FATHERPROJECTID = entity.FATHERPROJECTID,
                    COSTTIME = entity.COSTTIME,
                    STARTDATE = entity.STARTDATE,
                    ENDDATE = entity.ENDDATE,
                    PROGRESS = entity.PROGRESS,
                    PROJECTREMARK = entity.PROJECTREMARK,
                };

                return model;
            }

            return null;
        }


    }
}
