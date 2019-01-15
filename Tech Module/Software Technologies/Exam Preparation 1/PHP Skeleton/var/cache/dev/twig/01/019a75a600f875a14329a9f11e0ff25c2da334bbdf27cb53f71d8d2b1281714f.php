<?php

/* :task:delete.html.twig */
class __TwigTemplate_93e038053a4f305e42a3b5d92c23092130919c14dcfc4a3305fd88090a1dd2b6 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", ":task:delete.html.twig", 1);
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
        $__internal_070b00c3fdba466bb36299c31ffd782bd07ab0649040834e6805e6d285afcbed = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_070b00c3fdba466bb36299c31ffd782bd07ab0649040834e6805e6d285afcbed->enter($__internal_070b00c3fdba466bb36299c31ffd782bd07ab0649040834e6805e6d285afcbed_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":task:delete.html.twig"));

        $__internal_de674f1e899c792243a718c0bdb387c288fe303536e59ca2e719b22a9bbf87d4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_de674f1e899c792243a718c0bdb387c288fe303536e59ca2e719b22a9bbf87d4->enter($__internal_de674f1e899c792243a718c0bdb387c288fe303536e59ca2e719b22a9bbf87d4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":task:delete.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_070b00c3fdba466bb36299c31ffd782bd07ab0649040834e6805e6d285afcbed->leave($__internal_070b00c3fdba466bb36299c31ffd782bd07ab0649040834e6805e6d285afcbed_prof);

        
        $__internal_de674f1e899c792243a718c0bdb387c288fe303536e59ca2e719b22a9bbf87d4->leave($__internal_de674f1e899c792243a718c0bdb387c288fe303536e59ca2e719b22a9bbf87d4_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_de99db539f72c3414936b9e662ec7c751957457ee2749d42f551aacbb2264cc4 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_de99db539f72c3414936b9e662ec7c751957457ee2749d42f551aacbb2264cc4->enter($__internal_de99db539f72c3414936b9e662ec7c751957457ee2749d42f551aacbb2264cc4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_9322898b29f4bf2a528244c6fc52dbdc9658ff762bb93528970cbafabe63f6db = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9322898b29f4bf2a528244c6fc52dbdc9658ff762bb93528970cbafabe63f6db->enter($__internal_9322898b29f4bf2a528244c6fc52dbdc9658ff762bb93528970cbafabe63f6db_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "    <div id=\"delete-wrapper\">
        <section class=\"delete\">
            <article>
                <form action=\"";
        // line 7
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("delete", array("id" => $this->getAttribute(($context["task"] ?? $this->getContext($context, "task")), "id", array()))), "html", null, true);
        echo "\" method=\"POST\">
                    <h4>Do you want to delete this item?</h4>
                    <div class=\"box\">
                        <p>";
        // line 10
        echo twig_escape_filter($this->env, $this->getAttribute(($context["task"] ?? $this->getContext($context, "task")), "title", array()), "html", null, true);
        echo "</p>
                    </div>
                    <div class=\"box\">
                        <p class=\"description\">";
        // line 13
        echo twig_escape_filter($this->env, $this->getAttribute(($context["task"] ?? $this->getContext($context, "task")), "comments", array()), "html", null, true);
        echo "</p>
                    </div>

                    ";
        // line 16
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "

                    <button type=\"submit\">Delete</button>
                    <a href=\"";
        // line 19
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\">Cancel</a>
                </form>
            </article>
        </section>
    </div>
";
        
        $__internal_9322898b29f4bf2a528244c6fc52dbdc9658ff762bb93528970cbafabe63f6db->leave($__internal_9322898b29f4bf2a528244c6fc52dbdc9658ff762bb93528970cbafabe63f6db_prof);

        
        $__internal_de99db539f72c3414936b9e662ec7c751957457ee2749d42f551aacbb2264cc4->leave($__internal_de99db539f72c3414936b9e662ec7c751957457ee2749d42f551aacbb2264cc4_prof);

    }

    public function getTemplateName()
    {
        return ":task:delete.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  78 => 19,  72 => 16,  66 => 13,  60 => 10,  54 => 7,  49 => 4,  40 => 3,  11 => 1,);
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
    <div id=\"delete-wrapper\">
        <section class=\"delete\">
            <article>
                <form action=\"{{ path('delete', {'id': task.id}) }}\" method=\"POST\">
                    <h4>Do you want to delete this item?</h4>
                    <div class=\"box\">
                        <p>{{ task.title }}</p>
                    </div>
                    <div class=\"box\">
                        <p class=\"description\">{{ task.comments }}</p>
                    </div>

                    {{ form_row(form._token) }}

                    <button type=\"submit\">Delete</button>
                    <a href=\"{{ path('index') }}\">Cancel</a>
                </form>
            </article>
        </section>
    </div>
{% endblock %}", ":task:delete.html.twig", "D:\\PHP Skeleton\\app/Resources\\views/task/delete.html.twig");
    }
}
