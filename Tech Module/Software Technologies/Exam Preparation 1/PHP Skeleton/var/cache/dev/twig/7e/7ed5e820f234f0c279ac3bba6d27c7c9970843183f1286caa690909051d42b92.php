<?php

/* :task:index.html.twig */
class __TwigTemplate_55bb81b8f612bf6310534ef2ae5c7dcebf0bea8ab8457b22cb7a7086283544cb extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", ":task:index.html.twig", 1);
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
        $__internal_4c79d71e0cf6ae4e6b44dcb600f273605d388a82a36e1c0ce5acb85e6f8d9d28 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_4c79d71e0cf6ae4e6b44dcb600f273605d388a82a36e1c0ce5acb85e6f8d9d28->enter($__internal_4c79d71e0cf6ae4e6b44dcb600f273605d388a82a36e1c0ce5acb85e6f8d9d28_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":task:index.html.twig"));

        $__internal_dae7b42da3cd839bfe3e210d66da90886b45970b72018ddb57954605dcecbe8e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_dae7b42da3cd839bfe3e210d66da90886b45970b72018ddb57954605dcecbe8e->enter($__internal_dae7b42da3cd839bfe3e210d66da90886b45970b72018ddb57954605dcecbe8e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":task:index.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_4c79d71e0cf6ae4e6b44dcb600f273605d388a82a36e1c0ce5acb85e6f8d9d28->leave($__internal_4c79d71e0cf6ae4e6b44dcb600f273605d388a82a36e1c0ce5acb85e6f8d9d28_prof);

        
        $__internal_dae7b42da3cd839bfe3e210d66da90886b45970b72018ddb57954605dcecbe8e->leave($__internal_dae7b42da3cd839bfe3e210d66da90886b45970b72018ddb57954605dcecbe8e_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_d95d973021c6baf0708aac9eef6d56d1f5eb4f97c21c3fd7868a8f04bd93d215 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_d95d973021c6baf0708aac9eef6d56d1f5eb4f97c21c3fd7868a8f04bd93d215->enter($__internal_d95d973021c6baf0708aac9eef6d56d1f5eb4f97c21c3fd7868a8f04bd93d215_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_efff7eccaf23311c2a9a021aa97ffea251baa5c77aeef36f6d35221b5a638da1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_efff7eccaf23311c2a9a021aa97ffea251baa5c77aeef36f6d35221b5a638da1->enter($__internal_efff7eccaf23311c2a9a021aa97ffea251baa5c77aeef36f6d35221b5a638da1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<section class=\"home\">
    <h2>Tasks:</h2>
    ";
        // line 6
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable(($context["tasks"] ?? $this->getContext($context, "tasks")));
        foreach ($context['_seq'] as $context["_key"] => $context["task"]) {
            // line 7
            echo "    <article>
        <a href=\"";
            // line 8
            echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("delete", array("id" => $this->getAttribute($context["task"], "id", array()))), "html", null, true);
            echo "\" class=\"fa fa-window-close\">X</a>
        <h3>";
            // line 9
            echo twig_escape_filter($this->env, $this->getAttribute($context["task"], "title", array()), "html", null, true);
            echo "</h3>
        <p>";
            // line 10
            echo twig_escape_filter($this->env, $this->getAttribute($context["task"], "comments", array()), "html", null, true);
            echo "</p>
    </article>
    ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['_key'], $context['task'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 13
        echo "    <a id=\"create-button\" href=\"";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("create");
        echo "\">Create New</a>
    ";
        // line 15
        echo "</section>
";
        
        $__internal_efff7eccaf23311c2a9a021aa97ffea251baa5c77aeef36f6d35221b5a638da1->leave($__internal_efff7eccaf23311c2a9a021aa97ffea251baa5c77aeef36f6d35221b5a638da1_prof);

        
        $__internal_d95d973021c6baf0708aac9eef6d56d1f5eb4f97c21c3fd7868a8f04bd93d215->leave($__internal_d95d973021c6baf0708aac9eef6d56d1f5eb4f97c21c3fd7868a8f04bd93d215_prof);

    }

    public function getTemplateName()
    {
        return ":task:index.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  82 => 15,  77 => 13,  68 => 10,  64 => 9,  60 => 8,  57 => 7,  53 => 6,  49 => 4,  40 => 3,  11 => 1,);
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
<section class=\"home\">
    <h2>Tasks:</h2>
    {% for task in tasks %}
    <article>
        <a href=\"{{ path('delete', {id: task.id}) }}\" class=\"fa fa-window-close\">X</a>
        <h3>{{ task.title }}</h3>
        <p>{{ task.comments }}</p>
    </article>
    {% endfor  %}
    <a id=\"create-button\" href=\"{{ path('create') }}\">Create New</a>
    {#<button>Create New</button>#}
</section>
{% endblock %}", ":task:index.html.twig", "D:\\PHP Skeleton\\app/Resources\\views/task/index.html.twig");
    }
}
