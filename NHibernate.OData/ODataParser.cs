﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Engine;

namespace NHibernate.OData
{
    /// <summary>
    /// OData parser for NHibernate.
    /// </summary>
    public static class ODataParser
    {
        private static readonly ODataContext _context = new ODataContext();

        /// <summary>
        /// Parses an OData query string and builds an ICriteria for it.
        /// </summary>
        /// <param name="session">NHibernate session to build the
        /// ICriteria for.</param>
        /// <param name="entityName">Name of the entity to query.</param>
        /// <param name="queryString">OData query string.</param>
        /// <returns>An <see cref="ICriteria"/> based on the provided
        /// query string.</returns>
        public static ICriteria ODataQuery(this ISession session, string entityName, string queryString)
        {
            return _context.ODataQuery(session, entityName, queryString, null);
        }

        /// <summary>
        /// Builds an ICriteria for an already parsed query string.
        /// </summary>
        /// <param name="session">NHibernate session to build the
        /// ICriteria for.</param>
        /// <param name="entityName">Name of the entity to query.</param>
        /// <param name="queryStringParts">Unescaped query string parts.</param>
        /// <returns>An <see cref="ICriteria"/> based on the provided
        /// query string.</returns>
        public static ICriteria ODataQuery(this ISession session, string entityName, IEnumerable<KeyValuePair<string, string>> queryStringParts)
        {
            return _context.ODataQuery(session, entityName, queryStringParts, null);
        }

        /// <summary>
        /// Parses an OData query string and builds an ICriteria for it.
        /// </summary>
        /// <param name="session">NHibernate session to build the
        /// ICriteria for.</param>
        /// <param name="entityName">Name of the entity to query.</param>
        /// <param name="queryString">OData query string.</param>
        /// <param name="configuration">Extra configuration.</param>
        /// <returns>An <see cref="ICriteria"/> based on the provided
        /// query string.</returns>
        public static ICriteria ODataQuery(this ISession session, string entityName, string queryString, ODataParserConfiguration configuration)
        {
            Require.NotNull(session, "session");
            Require.NotNull(entityName, "entityName");
            Require.NotNull(queryString, "queryString");

            return _context.ODataQuery(session, entityName, queryString, configuration);
        }

        /// <summary>
        /// Builds an ICriteria for an already parsed query string.
        /// </summary>
        /// <param name="session">NHibernate session to build the
        /// ICriteria for.</param>
        /// <param name="entityName">Name of the entity to query.</param>
        /// <param name="queryStringParts">Unescaped query string parts.</param>
        /// <param name="configuration">Extra configuration.</param>
        /// <returns>An <see cref="ICriteria"/> based on the provided
        /// query string.</returns>
        public static ICriteria ODataQuery(this ISession session, string entityName, IEnumerable<KeyValuePair<string, string>> queryStringParts, ODataParserConfiguration configuration)
        {
            Require.NotNull(session, "session");
            Require.NotNull(entityName, "entityName");
            Require.NotNull(queryStringParts, "queryStringParts");

            return _context.ODataQuery(session, entityName, queryStringParts, configuration);
        }

        /// <summary>
        /// Parses an OData query string and builds an ICriteria for it.
        /// </summary>
        /// <param name="session">NHibernate session to build the
        /// ICriteria for.</param>
        /// <param name="persistentClass">Type of the entity to query.</param>
        /// <param name="queryString">OData query string.</param>
        /// <returns>An <see cref="ICriteria"/> based on the provided
        /// query string.</returns>
        public static ICriteria ODataQuery(this ISession session, System.Type persistentClass, string queryString)
        {
            return _context.ODataQuery(session, persistentClass, queryString, null);
        }

        /// <summary>
        /// Builds an ICriteria for an already parsed query string.
        /// </summary>
        /// <param name="session">NHibernate session to build the
        /// ICriteria for.</param>
        /// <param name="persistentClass">Type of the entity to query.</param>
        /// <param name="queryStringParts">Unescaped query string parts.</param>
        /// <returns>An <see cref="ICriteria"/> based on the provided
        /// query string.</returns>
        public static ICriteria ODataQuery(this ISession session, System.Type persistentClass, IEnumerable<KeyValuePair<string, string>> queryStringParts)
        {
            return _context.ODataQuery(session, persistentClass, queryStringParts, null);
        }

        /// <summary>
        /// Parses an OData query string and builds an ICriteria for it.
        /// </summary>
        /// <param name="session">NHibernate session to build the
        /// ICriteria for.</param>
        /// <param name="persistentClass">Type of the entity to query.</param>
        /// <param name="queryString">OData query string.</param>
        /// <param name="configuration">Extra configuration.</param>
        /// <returns>An <see cref="ICriteria"/> based on the provided
        /// query string.</returns>
        public static ICriteria ODataQuery(this ISession session, System.Type persistentClass, string queryString, ODataParserConfiguration configuration)
        {
            Require.NotNull(session, "session");
            Require.NotNull(persistentClass, "persistentClass");
            Require.NotNull(queryString, "queryString");

            return _context.ODataQuery(session, persistentClass, queryString, configuration);
        }

        /// <summary>
        /// Builds an ICriteria for an already parsed query string.
        /// </summary>
        /// <param name="session">NHibernate session to build the
        /// ICriteria for.</param>
        /// <param name="persistentClass">Type of the entity to query.</param>
        /// <param name="queryStringParts">Unescaped query string parts.</param>
        /// <param name="configuration">Extra configuration.</param>
        /// <returns>An <see cref="ICriteria"/> based on the provided
        /// query string.</returns>
        public static ICriteria ODataQuery(this ISession session, System.Type persistentClass, IEnumerable<KeyValuePair<string, string>> queryStringParts, ODataParserConfiguration configuration)
        {
            Require.NotNull(session, "session");
            Require.NotNull(persistentClass, "persistentClass");
            Require.NotNull(queryStringParts, "queryStringParts");

            return _context.ODataQuery(session, persistentClass, queryStringParts, configuration);
        }

        /// <summary>
        /// Parses an OData query string and builds an ICriteria for it.
        /// </summary>
        /// <param name="session">NHibernate session to build the
        /// ICriteria for.</param>
        /// <param name="queryString">OData query string.</param>
        /// <typeparam name="T">Type of the entity to query.</typeparam>
        /// <returns>An <see cref="ICriteria"/> based on the provided
        /// query string.</returns>
        public static ICriteria ODataQuery<T>(this ISession session, string queryString)
        {
            return _context.ODataQuery<T>(session, queryString, null);
        }

        /// <summary>
        /// Parses an OData query string and builds an ICriteria for it.
        /// </summary>
        /// <param name="session">NHibernate session to build the
        /// ICriteria for.</param>
        /// <param name="queryString">OData query string.</param>
        /// <param name="configuration">Extra configuration.</param>
        /// <typeparam name="T">Type of the entity to query.</typeparam>
        /// <returns>An <see cref="ICriteria"/> based on the provided
        /// query string.</returns>
        public static ICriteria ODataQuery<T>(this ISession session, string queryString, ODataParserConfiguration configuration)
        {
            return _context.ODataQuery(session, typeof(T), queryString, configuration);
        }

        /// <summary>
        /// Builds an ICriteria for an already parsed query string.
        /// </summary>
        /// <param name="session">NHibernate session to build the
        /// ICriteria for.</param>
        /// <param name="queryStringParts">Unescaped query string parts.</param>
        /// <typeparam name="T">Type of the entity to query.</typeparam>
        /// <returns>An <see cref="ICriteria"/> based on the provided
        /// query string.</returns>
        public static ICriteria ODataQuery<T>(this ISession session, IEnumerable<KeyValuePair<string, string>> queryStringParts)
        {
            return _context.ODataQuery<T>(session, queryStringParts, null);
        }

        /// <summary>
        /// Builds an ICriteria for an already parsed query string.
        /// </summary>
        /// <param name="session">NHibernate session to build the
        /// ICriteria for.</param>
        /// <param name="queryStringParts">Unescaped query string parts.</param>
        /// <param name="configuration">Extra configuration.</param>
        /// <typeparam name="T">Type of the entity to query.</typeparam>
        /// <returns>An <see cref="ICriteria"/> based on the provided
        /// query string.</returns>
        public static ICriteria ODataQuery<T>(this ISession session, IEnumerable<KeyValuePair<string, string>> queryStringParts, ODataParserConfiguration configuration)
        {
            return _context.ODataQuery(session, typeof(T), queryStringParts, configuration);
        }
    }
}
