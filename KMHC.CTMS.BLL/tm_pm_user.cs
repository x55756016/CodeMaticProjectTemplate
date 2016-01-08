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
    public class tm_pm_userBLL
    {
        protected static tm_pm_userDAL dal = new tm_pm_userDAL();

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string Add(V_tm_pm_user model)
        {
             if (model == null)
                return string.Empty;
            tm_pm_user entity = ModelToEntity(model);
            entity.USERID = string.IsNullOrEmpty(model.USERID) ? Guid.NewGuid().ToString("N") : model.USERID;

            return dal.Add(entity);
        }
		
		/// <summary>
        /// 获取单条数据
        /// </summary>
        /// <returns></returns>
        public V_tm_pm_user Get(Expression<Func<tm_pm_user, bool>> predicate = null)
        {
            tm_pm_user entity= dal.Get(predicate);
            return EntityToModel(entity); 
        }
		
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<V_tm_pm_user> Get()
        {
            List<tm_pm_user> entitys = dal.Get().ToList();
            List<V_tm_pm_user> list = new List<V_tm_pm_user>();
            foreach (tm_pm_user item in entitys)
            {
                list.Add(EntityToModel(item));
            }
            return list;
        }
        
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public IEnumerable<V_tm_pm_user> GetList(PageInfo page)
        {
            var list = dal.Get();

            return list.Paging(ref page).Select(EntityToModel).ToList();
        }
		
		/// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(V_tm_pm_user model)
        {
            if (model == null) return false;
            tm_pm_user entitys = ModelToEntity(model);
            
            return dal.Edit(entitys);
        }
        
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return false;

            return dal.Delete(id);
        }
      
        /// <summary>
        /// Model转Entity
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private tm_pm_user ModelToEntity(V_tm_pm_user model)
        {
            if (model != null)
            {
                tm_pm_user entity = new tm_pm_user()
                {
                	                    	USERID = model.USERID,
                                        	USERNAME = model.USERNAME,
                                        	EMAIL = model.EMAIL,
                                        	PHONE = model.PHONE,
                                        	PASSWORD = model.PASSWORD,
                                        	ISCLOSED = model.ISCLOSED,
                                        	POSTID = model.POSTID,
                                        	OWENRID = model.OWENRID,
                                        	OWNERDEPARTMENTID = model.OWNERDEPARTMENTID,
                                        	OWNERCOMPANYID = model.OWNERCOMPANYID,
                                        	CREATETIME = model.CREATETIME,
                                        	CREATEUSER = model.CREATEUSER,
                                        	EDITTIME = model.EDITTIME,
                                        	EDITUSER = model.EDITUSER,
                                        	OWNERPOSTID = model.OWNERPOSTID,
                                        	COST = model.COST,
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
        private V_tm_pm_user  EntityToModel(tm_pm_user  entity)
        {
            if (entity != null)
            {
                V_tm_pm_user  model = new V_tm_pm_user ()
                {
                                       	USERID = entity.USERID,
                                        	USERNAME = entity.USERNAME,
                                        	EMAIL = entity.EMAIL,
                                        	PHONE = entity.PHONE,
                                        	PASSWORD = entity.PASSWORD,
                                        	ISCLOSED = entity.ISCLOSED,
                                        	POSTID = entity.POSTID,
                                        	OWENRID = entity.OWENRID,
                                        	OWNERDEPARTMENTID = entity.OWNERDEPARTMENTID,
                                        	OWNERCOMPANYID = entity.OWNERCOMPANYID,
                                        	CREATETIME = entity.CREATETIME,
                                        	CREATEUSER = entity.CREATEUSER,
                                        	EDITTIME = entity.EDITTIME,
                                        	EDITUSER = entity.EDITUSER,
                                        	OWNERPOSTID = entity.OWNERPOSTID,
                                        	COST = entity.COST,
                                    };

                return model;
            }

            return null;
        }

       
    }
}
