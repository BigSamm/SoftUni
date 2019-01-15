<?php

/* :film:index.html.twig */
class __TwigTemplate_9fdc53195a5871ade17cb0a9b6e00d5eea64520000f1943c2d90114766c6a791 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", ":film:index.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_3264204cf1f75b6e7fa325fcc97c63b43b1287419ba67f59dd8fc8d25515b432 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_3264204cf1f75b6e7fa325fcc97c63b43b1287419ba67f59dd8fc8d25515b432->enter($__internal_3264204cf1f75b6e7fa325fcc97c63b43b1287419ba67f59dd8fc8d25515b432_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":film:index.html.twig"));

        $__internal_60d72c557241191065f43d99380f63cb059ed0cfd397d66b1fc481a254e9168a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_60d72c557241191065f43d99380f63cb059ed0cfd397d66b1fc481a254e9168a->enter($__internal_60d72c557241191065f43d99380f63cb059ed0cfd397d66b1fc481a254e9168a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":film:index.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_3264204cf1f75b6e7fa325fcc97c63b43b1287419ba67f59dd8fc8d25515b432->leave($__internal_3264204cf1f75b6e7fa325fcc97c63b43b1287419ba67f59dd8fc8d25515b432_prof);

        
        $__internal_60d72c557241191065f43d99380f63cb059ed0cfd397d66b1fc481a254e9168a->leave($__internal_60d72c557241191065f43d99380f63cb059ed0cfd397d66b1fc481a254e9168a_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_913fdaea69ae351730a04180d761d624cb20775a3814f4b47d7d087edcb7eb99 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_913fdaea69ae351730a04180d761d624cb20775a3814f4b47d7d087edcb7eb99->enter($__internal_913fdaea69ae351730a04180d761d624cb20775a3814f4b47d7d087edcb7eb99_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_1a5e3ca6feb492dff540bd557296e2b2efb56111700b5f3d6dede5ea6b750f40 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1a5e3ca6feb492dff540bd557296e2b2efb56111700b5f3d6dede5ea6b750f40->enter($__internal_1a5e3ca6feb492dff540bd557296e2b2efb56111700b5f3d6dede5ea6b750f40_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<h1>All Films</h1>

<div>
    <button class=\"add-new\" onclick=\"location.href='/create'\">Create New Film</button>
</div>

<section>
    <div>
        <table>
            <tr>
                <th>Name</th>
                <th>Genre</th>
                <th>Director</th>
                <th>Year</th>
                <th>Actions</th>
            </tr>
            ";
        // line 20
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable(($context["films"] ?? $this->getContext($context, "films")));
        foreach ($context['_seq'] as $context["_key"] => $context["film"]) {
            // line 21
            echo "            <tr>
                <td>";
            // line 22
            echo twig_escape_filter($this->env, $this->getAttribute($context["film"], "name", array()), "html", null, true);
            echo "</td>
                <td>";
            // line 23
            echo twig_escape_filter($this->env, $this->getAttribute($context["film"], "genre", array()), "html", null, true);
            echo "</td>
                <td>";
            // line 24
            echo twig_escape_filter($this->env, $this->getAttribute($context["film"], "director", array()), "html", null, true);
            echo "</td>
                <td>";
            // line 25
            echo twig_escape_filter($this->env, $this->getAttribute($context["film"], "year", array()), "html", null, true);
            echo "</td>
                <td>
                    <button onclick=\"location.href='/edit/";
            // line 27
            echo twig_escape_filter($this->env, $this->getAttribute($context["film"], "id", array()), "html", null, true);
            echo "'\" class=\"edit\">Edit</button>
                    <button onclick=\"location.href='/delete/";
            // line 28
            echo twig_escape_filter($this->env, $this->getAttribute($context["film"], "id", array()), "html", null, true);
            echo "'\" class=\"delete\">Delete</button>
                </td>
            </tr>
            ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['_key'], $context['film'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 32
        echo "        </table>
    </div>
</section>
";
        
        $__internal_1a5e3ca6feb492dff540bd557296e2b2efb56111700b5f3d6dede5ea6b750f40->leave($__internal_1a5e3ca6feb492dff540bd557296e2b2efb56111700b5f3d6dede5ea6b750f40_prof);

        
        $__internal_913fdaea69ae351730a04180d761d624cb20775a3814f4b47d7d087edcb7eb99->leave($__internal_913fdaea69ae351730a04180d761d624cb20775a3814f4b47d7d087edcb7eb99_prof);

    }

    public function getTemplateName()
    {
        return ":film:index.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  105 => 32,  95 => 28,  91 => 27,  86 => 25,  82 => 24,  78 => 23,  74 => 22,  71 => 21,  67 => 20,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<h1>All Films</h1>

<div>
    <button class=\"add-new\" onclick=\"location.href='/create'\">Create New Film</button>
</div>

<section>
    <div>
        <table>
            <tr>
                <th>Name</th>
                <th>Genre</th>
                <th>Director</th>
                <th>Year</th>
                <th>Actions</th>
            </tr>
            {% for film in films %}
            <tr>
                <td>{{ film.name }}</td>
                <td>{{ film.genre }}</td>
                <td>{{ film.director }}</td>
                <td>{{ film.year }}</td>
                <td>
                    <button onclick=\"location.href='/edit/{{ film.id }}'\" class=\"edit\">Edit</button>
                    <button onclick=\"location.href='/delete/{{ film.id }}'\" class=\"delete\">Delete</button>
                </td>
            </tr>
            {% endfor %}
        </table>
    </div>
</section>
{% endblock %}", ":film:index.html.twig", "D:\\PHP Skeleton\\app/Resources\\views/film/index.html.twig");
    }
}
